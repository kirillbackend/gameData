namespace GameBlocApi.Services.Interface
{
    /// <summary>
    /// Интерфейс для удаленя игры по Id
    /// </summary>
    public interface IDeleteGame
    {
        Task DeleteGame(int id);
    }
}