using AnimeUI.Data.Models;

namespace AnimeUI.Data.Interfaces.Services
{
    public interface IGetCharacters
    {
        Task <Character> GetByIdAsync(int id);

    }
}
