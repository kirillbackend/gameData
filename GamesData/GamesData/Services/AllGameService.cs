using GameBlocApi.Models.Entity;
using GameBlocApi.Services.Interface;
using GamesData.Models;

namespace GameBlocApi.Services
{
    /// <summary>
    /// Сервис для получения всех игр
    /// </summary>
    public class AllGameService : IAllGame
    {
        public async Task<List<Game>> GetGames()
        {
            await using (var context = new ApplicationContext())
            {
                var allGames = context.Games.ToList();
                if (allGames == null)
                    throw new ArgumentNullException(nameof(allGames));
                else
                    return allGames;
            }
        }
    }
}
