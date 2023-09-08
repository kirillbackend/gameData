using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Filters.Interface;

namespace GamesData.Services.Filters
{
    /// <summary>
    /// Сервис для фильтрации по рейтингу
    /// </summary>
    public class FilterRatingService : IRatingFilter
    {
        private List<Game> games;

        public FilterRatingService()
        {
            games = new List<Game>();
        }

        public async Task<List<Game>> GetGameAsync(RatingParams ratingParam, int rating)
        {
            await using (var context = new ApplicationContext())
            {
                return ratingParam switch
                {
                    RatingParams.more => games = context.Games.Where(r => r.RatingOnMetacritic > rating).ToList(),
                    RatingParams.less => games = context.Games.Where(r => r.RatingOnMetacritic < rating).ToList(),
                    RatingParams.equally => games = context.Games.Where(r => r.RatingOnMetacritic == rating).ToList()
                };
            }
        }
    }
}
