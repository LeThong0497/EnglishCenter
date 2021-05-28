using EnglisCenter.Accessor.Entities;
using EnglishCenter.Common.Models.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishCenter.Business.Interfaces
{
    public interface IResultService
    {
        Task<Result> Add(Result result);

        Task<IEnumerable<ResultResponse>> GetResult(int accId);
    }
}
