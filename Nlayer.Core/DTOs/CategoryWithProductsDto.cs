using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.DTOs
{
    public class CategoryWithProductsDto:CategoryDto
    {
        //Ek olarak lazım olan Dto modeli için gerekli olan property
        //Categorinin bağlı olduğu Productsları alacağımız için 
        public List<ProductDto> Products { get; set; }

    }
}
