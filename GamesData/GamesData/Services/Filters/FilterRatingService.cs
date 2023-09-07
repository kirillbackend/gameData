using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Filters.Interface;

namespace GamesData.Services.Filters
{
    public class FilterRatingService : IRatingFilter
    {
        public async Task<List<Game>> GetEquallyRatingGame(int rating)
        {
            await using (var context = new ApplicationContext())
            {
                var games = context.Games.Where(r => r.RatingOnMetacritic == rating).ToList();
                return games;
            }
        }
    }
}
