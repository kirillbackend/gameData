using GameBlocApi.Models.Entity;

namespace GameBlocApi.Services.Interface
{
    /// <summary>
    /// Интерфейл для добавления игры
    /// </summary>
    public interface IAddGame
    {
        Task AddGame(Game game);
    }
}