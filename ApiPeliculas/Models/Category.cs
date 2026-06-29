using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }


        public DateTime FechaCreacion { get; set; }
    }
}
