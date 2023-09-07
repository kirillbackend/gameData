using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Filters.Interface;

namespace GamesData.Services.Filters
{
    /// <summary>
    /// Сервис для фильтрации по году релиза
    /// </summary>
    public class FilterYearReleaseService : IYearRelease
    {
        public async Task<List<Game>> GetGames(int yearRelease)
        {
            await using (var context = new ApplicationContext())
            {
                var games = context.Games
                    .Where(y => y.YearOfRelease.Year == yearRelease).ToList();
                return games;
            }
        }
    }
}
