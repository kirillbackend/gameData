using GameBlocApi.Models.Entity;
using GamesData.Models;

namespace GamesData.Services.Filters.Interface
{
    /// <summary>
    /// Интерфейс для филтрации по игровой платформе 
    /// </summary>
    public interface IFilterPlatform
    {
        Task<List<Game>> GetGameAsync(Platforms platform);
    }
}