using GameBlocApi.Models.Entity;
using GamesData.Models;

namespace GamesData.Services.Filters.Interface
{
    public interface IRatingFilter
    {
        Task<List<Game>> GetEquallyRatingGame(int rating);
    }
}