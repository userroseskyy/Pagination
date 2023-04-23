using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Display(Name ="نام شخص")]
        [Required(ErrorMessage ="لطفا {0} خود را وارد کنید")]
        public string FullName { get; set; }
    }
}
