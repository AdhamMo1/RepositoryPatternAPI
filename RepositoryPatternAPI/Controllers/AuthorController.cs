using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternAPI.Core;
using RepositoryPatternAPI.Core.Models;
using RepositoryPatternAPI.Core.RepositoryInterfaces;

namespace RepositoryPatternAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController(IUnitOfWork UnitOkWork) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAuthorById()
        {
            return Ok(UnitOkWork.Authors.GetById(1));
        }
        [HttpGet("FindByName")]
        public IActionResult Find()
        {
            return Ok(UnitOkWork.Authors.Find(x => x.Name == "Adham"));
        }
    }
}
