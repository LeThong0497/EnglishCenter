using EnglisCenter.Accessor.Entities;
using EnglishCenter.Business.Interfaces;
using EnglishCenter.Common.Models.Result;
using System.Threading.Tasks;

namespace EnglishCenter.Business.Services
{
    public class ResultService : IResultService
    {
        private readonly IBaseRepository<Result> _baseRepository;

        public ResultService(IBaseRepository<Result> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<Result> Add(Result result)
        {          
            return  await  _baseRepository.Add(result);
        }
    }
}
