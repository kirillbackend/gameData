using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Filters.Interface;

namespace GamesData.Services.Filters
{
    /// <summary>
    /// Сервис для фильтрации игр по названию
    /// </summary>
    public class FilterNameService : IFilterName
    {
        public async Task<List<Game>> GetGameAsync(string name)
        {
            await using (var context = new ApplicationContext())
            {
                var games = context.Games.Where(n => n.Name.Contains(name)).ToList();
                return games;
            }
        }
    }
}
