using EnglisCenter.Accessor.Entities;
using EnglishCenter.Common.Models.Result;
using System.Threading.Tasks;

namespace EnglishCenter.Business.Interfaces
{
    public interface IResultService
    {
        Task<Result> Add(Result result);
    }
}
