using GameBlocApi.Models.Entity;

namespace GamesData.Services.Interface
{
    /// <summary>
    /// Интерфейс для полученя игры по Id
    /// </summary>
    public interface IOneGame
    {
        Task<Game> GetGame(int id);
    }
}