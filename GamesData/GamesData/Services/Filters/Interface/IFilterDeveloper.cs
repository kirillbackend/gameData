using GameBlocApi.Models.Entity;

namespace GamesData.Services.Filters.Interface
{
    /// <summary>
    /// Интерфейс для фильтрации по разработчику
    /// </summary>
    public interface IFilterDeveloper
    {
        Task<List<Game>> GetGamesAsync(string developer);
    }
}