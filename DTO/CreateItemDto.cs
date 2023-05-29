using System.ComponentModel.DataAnnotations;

namespace Catalog.DTO
{
    public class CreateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}