﻿using AutoMapper;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CustomResponseDTO<CategoryWithProductsDTO>> GetSingleCategoryByIdWidthProductAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdWidthProductAsync(categoryId);
            var categoryDTO = _mapper.Map<CategoryWithProductsDTO>(category);
            return CustomResponseDTO<CategoryWithProductsDTO>.Success(200, categoryDTO);

        }
    }
}
