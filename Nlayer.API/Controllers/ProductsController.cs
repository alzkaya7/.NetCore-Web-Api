using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nlayer.Core;
using Nlayer.Core.DTOs;
using Nlayer.Core.Services;

namespace Nlayer.API.Controllers
{

    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
     
        private readonly IProductService _service;
        public ProductsController(IMapper mapper, IService<Product> service = null, IProductService productService = null)
        {
            _mapper = mapper;
            _service = productService;
        }

        [HttpGet("[action]")] //Method isminden api servisi çağırılıcak ..
        public async Task<IActionResult> GetProductWithCategory()
        {
            return CreateActionResult(await _service.GetProductsWithCategory());

        }

        [HttpGet]
        public async Task<IActionResult> All() // tüm üürmnleri listele getirme işlemi ..
        {
            var products=await _service.GetAllAsync(); //Bütün veriyi aldım.. 

            var productsDtos=_mapper.Map<List<ProductDto>>(products.ToList()); //mapleme işlemini yaptım ..

            //return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));

            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos)); //Teker teker elle ok ,badrequest  vs durum kodlaır yerine bir method tanımdaldım  ve ona göre işlem yaptım ..


        }


        [HttpGet("{id}")]  //ıd ye göre getirme işlemni ..
        public async Task<IActionResult> GetById(int id)
        {
            var products = await _service.GetByIdAsync(id); //Bütün veriyi aldım.. 

            var productDtos = _mapper.Map<ProductDto>(products); //mapleme işlemini yaptım ..
        
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDtos)); //Teker teker elle ok ,badrequest  vs durum kodlaır yerine bir method tanımdaldım  ve ona göre işlem yaptım ..


        }

        [HttpPost] //Ekleme işlemi
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var products = await _service.AddAsync(_mapper.Map<Product>(productDto)); 

            var productDtos = _mapper.Map<ProductDto>(products); //mapleme işlemini yaptım ..

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productDtos)); //Teker teker elle ok ,badrequest  vs durum kodlaır yerine bir method tanımdaldım  ve ona göre işlem yaptım ..


        }

        [HttpPut] //Güncelleme işlemi
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto)); //Geriye dönüşe gerek olmadığı için  direkl awit ile başladım ..
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204)); //Teker teker elle ok ,badrequest  vs durum kodlaır yerine bir method tanımdaldım  ve ona göre işlem yaptım ..
        //Delete ve updpate işlemerlinde nesneyi görmek ismtedğimden bilgisine ihtiyaç duymadığımdan deriye ürünü döndürmedim . nocontent döndüm ..

        }

        [HttpDelete("{id}")] //Silme işlemi
        public async Task<IActionResult> Remove(int id )
        {
            var products = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(products); //Geriye dönüşe gerek olmadığı için  direkl awit ile başladım ..
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204)); //Teker teker elle ok ,badrequest  vs durum kodlaır yerine bir method tanımdaldım  ve ona göre işlem yaptım ..
           
            //Delete ve updpate işlemerlinde nesneyi görmek ismtedğimden bilgisine ihtiyaç duymadığımdan deriye ürünü döndürmedim . nocontent döndüm ..
            //T data dönülmedi ..
        }

     
    }
}
