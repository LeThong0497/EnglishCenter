using System.ComponentModel.DataAnnotations;

namespace EnglisCenter.Accessor.Entities
{ 
    public class DetailResult
    {
        [Key]
        public int Id { get; set; }

        public int ResultId { get; set; }

        public string SelectedAns { get; set; }

    }
}
