using GameBlocApi.Models.Entity;
using GamesData.Models;

namespace GamesData.Services.Filters.Interface
{
    /// <summary>
    /// Интерфейс для фильтрации по рейтенгу игры
    /// </summary>
    public interface IRatingFilter
    {
        Task<List<Game>> GetGameAsync(RatingParams ratingParam, int rating);
    }
}