using GameBlocApi.Models.Entity;

namespace GamesData.Services.Interface
{
    /// <summary>
    /// Интерфейс для обновления игры
    /// </summary>
    public interface IPatchGame
    {
        Task PatchGame(Game game);
    }
}