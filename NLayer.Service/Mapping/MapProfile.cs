using AutoMapper;
using Nlayer.Core;
using Nlayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
    public  class MapProfile:Profile
    {
        //Mapleme profilleri oluştıuruyoum ..

        public MapProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap(); //tam tersine de olabilir mapleme o yüzden reverse Map ..
            CreateMap<Category,CategoryDto>().ReverseMap(); 
            CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<Category, CategoryWithProductsDto>();
    

        }



    }
}
