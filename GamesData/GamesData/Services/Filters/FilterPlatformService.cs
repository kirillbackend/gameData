using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Filters.Interface;

namespace GamesData.Services.Filters
{
    /// <summary>
    /// Сервис для фильтрации по игровой платформе
    /// </summary>
    public class FilterPlatformService : IFilterPlatform
    {
        public async Task<List<Game>> GetGameAsync(Platforms platform)
        {
            await using (var context = new ApplicationContext())
            {
                var game = context.Games.Where(p => p.Platforms.Contains(platform.ToString())).ToList();
                return game;
            }
        }
    }
}
