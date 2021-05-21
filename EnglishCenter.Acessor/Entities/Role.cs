using System.ComponentModel.DataAnnotations;

namespace EnglisCenter.Accessor.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        public string Name { get; set; }

    }
}
