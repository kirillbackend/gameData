using GamesData.Services.Filters.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GamesData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesFiltersController : ControllerBase
    {
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
                var game = await filterNameService.GetGames(name);
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
            var game = await yearReleaseService.GetGames(yearRelease);
            return Ok(game);
        }

        /// <summary>
        /// Получение всех игр отфилтрованнх по рейтингу
        /// </summary>
        /// <param name="rating"> рейтинг игры </param>
        /// <param name="ratingFilterService"> сервис фильтрации по рейтингу </param>
        /// <returns> список игр по рейтингу </returns>
        [HttpGet, Route("Rating")]
        public async Task<ActionResult> GetGame([FromQuery] int rating, IRatingFilter ratingFilterService)
        {
            var game = await ratingFilterService.GetEquallyRatingGame(rating);
            return Ok(game);
        }
    }
}
