using GameBlocApi.Models.Entity;

namespace GamesData.Services.Filters.Interface
{
    /// <summary>
    /// Интерфейс для фильтрации по имени игры
    /// </summary>
    public interface IFilterName
    {
        Task<List<Game>> GetGames(string name);
    }
}