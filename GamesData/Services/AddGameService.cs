using GameBlocApi.Models.Entity;
using GameBlocApi.Services.Interface;
using GamesData.Models;

namespace GameBlocApi.Services
{
    /// <summary>
    /// Сервис для добавления игры
    /// </summary>
    public class AddGameService : IAddGame
    {
        public async Task AddGame(Game game)
        {
            await using (var context = new ApplicationContext())
            {
                context.Games.Add(game);
                context.SaveChanges();
            }
        }
    }
}
