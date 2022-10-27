using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.Services;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieServices _service;
        public MovieController()
        {
            _service = new MovieServices();
        }
        //define action-methods
        [HttpGet]
        [Route("GetMovies")]
        public IActionResult GetMovies()
        {
            try
            {
                List<Movie> Movies = _service.GetMovies();
                return StatusCode(200, Movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieById/{MovieId}")]
        public IActionResult GetMovieById(int MovieId)
        {
            try
            {
                Movie Movie = _service.GetMovieById(MovieId);
                if (Movie != null)
                    return StatusCode(200, Movie);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddMovie")]
        public IActionResult AddMovie(Movie Movie)
        {
            try
            {
                _service.AddMovie(Movie);
                return StatusCode(200, "Record Added");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpPut]
        [Route("EditMovie")]
        public IActionResult EditMovie(Movie Movie)
        {
            try
            {
                _service.UpdateMovie(Movie);
                return StatusCode(200, "Record Updated");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{MovieId}")]
        public IActionResult DeleteMovie(int MovieId)
        {
            try
            {
                _service.DeleteMovie(MovieId);
                return StatusCode(200, "Record Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetMovieByActor/{Actor}")]
        public IActionResult GetMovieByActor(String Actor)
        {
            try
            {
                Movie Movie = _service.GetMovieByActor(Actor);
                if (Movie != null)
                    return StatusCode(200, Movie);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetMovieByLang/{Lang}")]
        public IActionResult GetMovieByLang(String Lang)
        {
            try
            {
                Movie Movie = _service.GetMovieByLang(Lang);
                if (Movie != null)
                    return StatusCode(200, Movie);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieByDirector/{Director}")]
        public IActionResult GetMovieByDirector(String Director)
        {
            try
            {
                Movie Movie = _service.GetMovieByDirector(Director);
                if (Movie != null)
                    return StatusCode(200, Movie);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
