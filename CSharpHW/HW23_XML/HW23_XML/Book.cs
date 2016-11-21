using System.ComponentModel.DataAnnotations;

namespace HW23_XML
{
    public class Book
    {
        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters please for Title")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters please for Author")]
        public string Author { get; set; }
        [Required]
        [StringLength(6)]
        [RegularExpression(@"\$\d+\.\d{2}", ErrorMessage = "UUse only number for Price")]
        public string Price { get; set; }
        [Required]
        [StringLength(4)]
        [RegularExpression(@"\$\d", ErrorMessage = "Use only number for Year")]
        public string Year { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
