using Catalog.DTO;
using Catalog.Entities;

namespace Catalog
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Name = item.Name,
                Id = item.Id,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}