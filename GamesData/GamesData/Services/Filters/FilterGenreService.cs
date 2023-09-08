using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Filters.Interface;

namespace GamesData.Services.Filters
{
    /// <summary>
    /// Сервис для фильтрации по игровому жанру
    /// </summary>
    public class FilterGenreService : IFilterGenre
    {
        public async Task<List<Game>> GetGamesAsync(string genre)
        {
            await using (var context = new ApplicationContext())
            {
                var game = context.Games.Where(g => g.Genre.Contains(genre)).ToList();
                return game;
            }
        }
    }
}
