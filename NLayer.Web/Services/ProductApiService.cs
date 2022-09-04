﻿using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class ProductApiService
    {
        private readonly HttpClient _httpClient;

        public ProductApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductWithCategoryDTO>> GetProductsWithCategoryAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<List<ProductWithCategoryDTO>>>("products/GetProductsWithCategory");
            return response.Data;
        }

        public async Task<ProductDTO> SaveAsync(ProductDTO newProduct)
        {
            var response = await _httpClient.PostAsJsonAsync("products", newProduct);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDTO<ProductDTO>>();
            return responseBody.Data;
        }

        public async Task<bool> UpdateAsync(ProductDTO newProduct)
        {
           var response= await _httpClient.PutAsJsonAsync("products", newProduct);
            return response.IsSuccessStatusCode;
        }  
        
        public async Task<bool> RemoveAsync(int id)
        {
           var respnse= await _httpClient.DeleteAsync($"products/{id}");
            return respnse.IsSuccessStatusCode;
        }

        public async Task<ProductDTO> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<ProductDTO>>($"products/{id}");
            return response.Data;
        }
    }
}
