using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CategoryDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<List<CategoryDTO>>>("categories");
            return response.Data;
        }

        public async Task<CategoryDTO> SaveAsync(CategoryDTO newCategory)
        {
            var response = await _httpClient.PostAsJsonAsync("category", newCategory);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDTO<CategoryDTO>>();
            return responseBody.Data;
        }

        public async Task<CategoryDTO> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDTO<CategoryDTO>>($"category/{id}");
            return response.Data;
        }

        public async Task<bool> UpdateAsync(CategoryDTO newCategory)
        {
            var response = await _httpClient.PutAsJsonAsync("category", newCategory);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"category/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
