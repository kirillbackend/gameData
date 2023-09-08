using GameBlocApi.Models.Entity;

namespace GamesData.Services.Filters.Interface
{
    /// <summary>
    /// Интерфейс для фильтрации по игровому жанру
    /// </summary>
    public interface IFilterGenre
    {
        Task<List<Game>> GetGamesAsync(string genre);
    }
}