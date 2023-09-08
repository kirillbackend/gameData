using GameBlocApi.Models.Entity;
using GamesData.Models;
using GamesData.Services.Interface;

namespace GamesData.Services
{
    /// <summary>
    /// Сервис для обновленя игры
    /// </summary>
    public class PatchGameService : IPatchGame
    {
        public async Task PatchGame(Game game)
        {
            await using (var context = new ApplicationContext())
            {
                var oldGame = context.Games.FirstOrDefault(i => i.Id == game.Id);
                if (oldGame != null) 
                {
                    oldGame.Update = game.Update;
                    oldGame.Platforms = game.Platforms;
                    oldGame.Genre = game.Genre;
                    oldGame.Name = game.Name;
                    oldGame.Developer = game.Developer;
                    oldGame.YearOfRelease = game.YearOfRelease;
                    oldGame.RatingOnMetacritic = game.RatingOnMetacritic;
                    context.Games.Update(oldGame);
                    context.SaveChanges();
                }
                else
                    throw new ArgumentNullException(nameof(game));
            }
        }
    }
}
