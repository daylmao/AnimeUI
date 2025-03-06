using AnimeUI.Data.Interfaces.Services;
using AnimeUI.Data.Models;
using System.Net.Http.Json;

namespace AnimeUI.Data.Services
{
    public class GetCharacter : IGetCharacters
    {
        private readonly HttpClient _httpClient;

        public GetCharacter(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Character?> GetByIdAsync(int id)
        {
            try
            {
                var characters = await _httpClient.GetFromJsonAsync<Character>($"characters/{id}");

                return characters ;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching characters: {ex.Message}");
                return null ;
            }
        }
    }
}
