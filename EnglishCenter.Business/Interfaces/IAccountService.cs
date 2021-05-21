using EnglisCenter.Accessor.Entities;
using EnglishCenter.Common.Models.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishCenter.Business.Interfaces
{
    public interface IAccountService
    {
        Task<Account> Add(AccountRequest accountRequest);

        Task<Account> GetById(int id);

        Task<IEnumerable<Account>> GetAll();

        Task<Account> Update(int id, AccountEditRequest accountEditRequest);
    }
}
