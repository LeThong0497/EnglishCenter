﻿using EnglisCenter.Accessor.Entities;
using EnglishCenter.Business.Interfaces;
using EnglishCenter.Common.Models.Account;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EnglishCenter.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly IBaseRepository<Account> _baseRepository;

        public AccountService(IBaseRepository<Account> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Account> Add(AccountRequest accountRequest)
        {
            var ac = _baseRepository.Entities.Where(x => x.Email == accountRequest.Email).FirstOrDefault();

            if (ac != null)
            {
                throw new Exception("This email is exist");
            }

            //Tạo mật khẩu ngẫu nhiên
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var passWord = new String(stringChars);
            //Gửi mail mật khẩu
            SmtpClient smtp = new SmtpClient
            {  
                UseDefaultCredentials=false,
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential("thongle0497@gmail.com", "lethongLT@0497#!"),
                Timeout = 5000,
            };
            MailMessage msg = new MailMessage("thongle0497@gmail.com", accountRequest.Email.ToString().Trim(),
                "Trung tâm AL - Cấp mật khẩu",
                "Cảm ơn đã đăng ký thi tại trung tâm AL. Mật khẩu của bạn là: " + passWord + "\nChú ý: tên đăng nhập chính là email của bạn.\n Chúc bạn đạt kết quả tốt!");
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);
            }
            catch(Exception e)
            {
                throw new Exception("Error"+e);
            }
            

            //Update mật khẩu vào db          
            var acc = new Account
            {
                FullName = accountRequest.FullName,
                Email = accountRequest.Email,
                CourseId = accountRequest.CourseId,
                PassWord = passWord,
                RoleId = 2,
            };

            return await _baseRepository.Add(acc);
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            var list = await _baseRepository.GetAll();

            if (list == null)
            {
                return null;
            }
            return list;
        }

        public async Task<Account> GetById(int id)
        {
            return await _baseRepository.GetById(id);
        }

        public async Task<Account> Update(AccountEditRequest accountEditRequest)
        {
            var acc = await _baseRepository.Entities
                .Where(x => x.Email.Equals(accountEditRequest.Email))
                .FirstOrDefaultAsync();

            if (acc == null)
                return null;
          
            acc.FullName = accountEditRequest.FullName;
            acc.DateOfBirth = accountEditRequest.DateOfBirth;
            acc.PhoneNumber = accountEditRequest.PhoneNumber;
            acc.Gender = accountEditRequest.Gender;
            acc.Address = accountEditRequest.Address;
            acc.CourseId = accountEditRequest.CourseId;

            return await _baseRepository.Update(acc);
        }
       
        public async Task<bool> ForgetPassWord(string email)
        {
            var acc =await _baseRepository.Entities.Where(x => x.Email.Equals(email)).FirstOrDefaultAsync();

            if (acc == null)
                return false;

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential("thongle0497@gmail.com", "lethongLT@0497#!"),
                Timeout = 5000,
            };
            MailMessage msg = new MailMessage("thongle0497@gmail.com", acc.Email.ToString().Trim(),
                "Trung tâm AL - Cấp mật khẩu",
                "Mật khẩu của bạn là: " + acc.PassWord.ToString() + "\n Chúc bạn đạt kết quả tốt!");
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);
            }
            catch (Exception e)
            {
                throw new Exception("Error" + e);
            }

            return true;
        }

        public async Task<bool> ChangePassword(int id,AccountChangePassword account )
        {
            var acc =await _baseRepository.GetById(id);

            if (acc == null)
                throw new Exception("Not Found");

            if(!acc.PassWord.Equals(account.OldPassWord))
            {
                return false;
            }

            acc.PassWord = account.NewPassWord;

            await  _baseRepository.Update(acc);

            return true;
        }
    }
}
