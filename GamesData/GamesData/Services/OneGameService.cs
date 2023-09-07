using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Interface;

namespace GamesData.Services
{
    /// <summary>
    /// Сервис для получения иры по Id
    /// </summary>
    public class OneGameService : IOneGame
    {
        public async Task<Game> GetGame(int id)
        {
            await using (var context = new ApplicationContext())
            {
                var game = context.Games.FirstOrDefault(x => x.Id == id);
                if (game == null)
                    throw new ArgumentNullException(nameof(game));
                else
                    return game;
            }
        }
    }
}
