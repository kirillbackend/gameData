using GameBlocApi.Services.Interface;
using GamesData.Models;
using GamesData.Services.Filters.Interface;
using GamesData.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GamesData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesFiltersController : ControllerBase
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
        /// Получение всех игр отфилтрованнх по символам которые есть в названии
        /// </summary>
        /// <param name="name"> символы </param>
        /// <param name="filterNameService"> фильтр по названию </param>
        /// <returns> список игр по определенному названию </returns>
        [HttpGet, Route("NameGame")]
        public async Task<ActionResult> GetGame([FromQuery] string name, IFilterName filterNameService)
        {
            if (name == null)
                return NotFound();
            else
            {
                var game = await filterNameService.GetGameAsync(name);
                return Ok(game);
            }
        }

        /// <summary>
        /// Получение всех игр отфилтрованнх по определенному году релиза
        /// </summary>
        /// <param name="yearRelease"> год релиза </param>
        /// <param name="yearReleaseService"> фильт по году релиза </param>
        /// <returns> список игр по определенному году </returns>
        [HttpGet, Route("YearReleaseGame")]
        public async Task<ActionResult> GetGame([FromQuery] int yearRelease, IYearRelease yearReleaseService)
        {
            var game = await yearReleaseService.GetGameAsync(yearRelease);
            return Ok(game);
        }

        /// <summary>
        /// Получение всех игр отфилтрованнх по рейтингу
        /// </summary>
        /// <param name="rating"> рейтинг игры </param>
        /// <param name="ratingFilterService"> сервис фильтрации по рейтингу </param>
        /// <returns> список игр по рейтингу </returns>
        [HttpGet, Route("Rating")]
        public async Task<ActionResult> GetGame([FromQuery] RatingParams ratingParam, [FromQuery] int rating, IRatingFilter ratingFilterService)
        {
            var game = await ratingFilterService.GetGameAsync(ratingParam, rating);
            return Ok(game);
        }

        /// <summary>
        /// Получение всех игр по определенной платформе
        /// </summary>
        /// <param name="platform"> платформа </param>
        /// <param name="filterPlatformService"> сервис фильтрации по платформе </param>
        /// <returns> список игр по платформе </returns>
        [HttpGet, Route("Platforms")]
        public async Task<ActionResult> GetGame([FromQuery] Platforms platform, IFilterPlatform filterPlatformService)
        {
            var game = await filterPlatformService.GetGameAsync(platform);
            return Ok(game);
        }

        /// <summary>
        /// Получение всех игр по разработчику
        /// </summary>
        /// <param name="developer"> название разработчика </param>
        /// <param name="filterDeveloperService"> сервис фильрации по разработчику </param>
        /// <returns> список игр по разработчику </returns>
        [HttpGet, Route("Developer")]
        public async Task<ActionResult> GetGame([FromQuery] string developer, IFilterDeveloper filterDeveloperService)
        {
            var game = await filterDeveloperService.GetGamesAsync(developer);
            return Ok(game);
        }

        /// <summary>
        /// Получение всех игр по жанру
        /// </summary>
        /// <param name="genre"> жанр игры </param>
        /// <param name="filterGenreService"> сервис фильтрации по игровому жанру </param>
        /// <returns> список игр по определенному жанру </returns>
        [HttpGet, Route("Genre")]
        public async Task<ActionResult> GetGame([FromQuery] string genre, IFilterGenre filterGenreService)
        {
            var game = await filterGenreService.GetGamesAsync(genre);
            return Ok(game);
        }
    }
}
