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
