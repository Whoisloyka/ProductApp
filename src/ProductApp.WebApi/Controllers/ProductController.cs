using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.DTO;
using ProductApp.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // WebApi'nin bu işlemi yapmaması lazım. Doğrudan domain entity'e ulaşıp sonrdan DTO'ya çevirmek yerine bu işlemi Application katmanında yapmamız daha uygundur.
            // Mapping işlemi ile bunu Application'da çözeceğiz. WebApi'mize domain entity değil DTO gelecek. bunları CQRS ve Mediator yöntemleriyle yapacağız.
            var allList = await productRepository.GetAllAsync();
            var result = allList.Select(i => new ProductViewDTO()
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();
            return Ok(result);
        }
    }
}
