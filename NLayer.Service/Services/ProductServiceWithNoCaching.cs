using AutoMapper;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class ProductServiceWithNoCaching : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRespository;
        private readonly IMapper _mapper;
        public ProductServiceWithNoCaching(IProductRepository productRespository, IMapper mapper,IGenericRepository<Product> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRespository = productRespository;
        }
        public async Task<CustomResponseDTO<List<ProductWithCategoryDTO>>> GetProductWithCategory()
        {
            var products = await _productRespository.GetProductWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategoryDTO>>(products);
            return CustomResponseDTO<List<ProductWithCategoryDTO>>.Success(200,productsDto);
        }
    }
}
