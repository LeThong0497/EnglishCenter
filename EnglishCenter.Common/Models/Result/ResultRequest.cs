using System.Collections.Generic;

namespace EnglishCenter.Common.Models.Result
{
    public class ResultRequest
    {
        public int AccountId { get; set; }
        public int TestId { get; set; }
        public int Score { get; set; }
        public List<string> Answers { get; set; }
    }
}
