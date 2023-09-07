using GameBlocApi.Models.Entity;

namespace GamesData.Services.Filters.Interface
{
    /// <summary>
    /// Интерфейс для фильтрации по году релиза
    /// </summary>
    public interface IYearRelease
    {
        Task<List<Game>> GetGames(int yearRelease);
    }
}