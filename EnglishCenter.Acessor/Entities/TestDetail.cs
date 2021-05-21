using System.ComponentModel.DataAnnotations;

namespace EnglisCenter.Accessor.Entities
{
    public class TestDetail
    {
        [Key]
        public int Id { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
      
        public virtual Question Question { get; set; }
    }
}
