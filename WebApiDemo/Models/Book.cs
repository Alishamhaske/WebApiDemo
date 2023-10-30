using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    //this class is called entity class /BO business object / POCO (plan old clr object)
    //map class with table in DB  (match table name)

    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Author { get; set; }

        [Required]
        public int Price { get; set; }


    }
}
