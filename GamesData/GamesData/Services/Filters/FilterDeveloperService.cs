using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Filters.Interface;

namespace GamesData.Services.Filters
{
    /// <summary>
    /// Сервис для фильтрации по разработчику
    /// </summary>
    public class FilterDeveloperService : IFilterDeveloper
    {
        public async Task<List<Game>> GetGamesAsync(string developer)
        {
            await using (var context = new ApplicationContext())
            {
                var games = context.Games.Where(d => d.Developer.Contains(developer)).ToList();
                return games;
            }
        }
    }
}
