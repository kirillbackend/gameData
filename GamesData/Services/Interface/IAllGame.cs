using GameBlocApi.Models.Entity;

namespace GameBlocApi.Services.Interface
{
    /// <summary>
    /// Интерфейс для получения всех игр
    /// </summary>
    public interface IAllGame
    {
        Task<List<Game>> GetGames();
    }
}