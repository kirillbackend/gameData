using GameBlocApi.Models.Entity;
using GameBlocApi.Services.Interface;
using GamesData.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GamesData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        /// <summary>
        /// Выводит список всех Игр
        /// </summary>
        /// <param name="allGamesServise"></param>
        /// <returns> Список всех игр </returns>
        [HttpGet, Route("AllGames")]
        public async Task<ActionResult> GetGame(IAllGame allGamesServise)
        {
            var allGames = await allGamesServise.GetGames();
            if (!allGames.Any())
                return NotFound();
            else
                return Ok(allGames);
        }

        /// <summary>
        /// Получение игры по Id
        /// </summary>
        /// <param name="id"> Id игры </param>
        /// <param name="gameService"> Сервис для получения игры </param>
        /// <returns> Игра по указанному Id </returns>
        [HttpGet, Route("OneGame")]
        public async Task<ActionResult> GetGame([FromQuery] int id, IOneGame gameService)
        {
            var game = await gameService.GetGame(id);
            if (game == null)
                return NotFound();
            else
                return Ok(game);
        }

        /// <summary>
        /// Добавляет новую игру
        /// </summary>
        /// <param name="game"></param>
        /// <param name="addGameService"></param>
        /// <returns> Статус обработки данных </returns>
        [HttpPost, Route("AddGame")]
        public async Task<ActionResult> PostGame([FromBody] Game game, IAddGame addGameService)
        {
            if (game == null)
                return BadRequest();
            else
            {
                await addGameService.AddGame(game);
                return Ok();
            }
        }

        /// <summary>
        /// Удаляет игру
        /// </summary>
        /// <param name="id"> Id удаляемой игры </param>
        /// <param name="deleteGameServise"> Сервис удаления </param>
        /// <returns> Статус обработки данных </returns>
        [HttpDelete, Route("DeleteGame")]
        public async Task<ActionResult> DeleteGame([FromQuery] int id, IDeleteGame deleteGameServise)
        {
            await deleteGameServise.DeleteGame(id);
            return Ok();
        }

        /// <summary>
        /// Обновление игры 
        /// </summary>
        /// <param name="game"> данные игры </param>
        /// <param name="patchGameService"></param>
        /// <returns></returns>
        [HttpPatch, Route("PatchGame")]
        public async Task<ActionResult> PatchGame([FromBody] Game game, IPatchGame patchGameService)
        {
            if (game == null)
                return NotFound();
            else
            {
                await patchGameService.PatchGame(game);
                return Ok();
            }
        }
    }
}
