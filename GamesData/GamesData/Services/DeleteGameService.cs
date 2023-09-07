using GameBlocApi.Services.Interface;
using GamesData.Models;

namespace GameBlocApi.Services
{
    /// <summary>
    /// Сервис для удаления игры по Id
    /// </summary>
    public class DeleteGameService : IDeleteGame
    {
        public async Task DeleteGame(int id)
        {
            await using (var context = new ApplicationContext())
            {
                var game = context.Games.FirstOrDefault(x => x.Id == id);
                if (game != null)
                {
                    context.Remove(game);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
