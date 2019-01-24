using Microsoft.AspNetCore.Mvc;
using SnackBar.Domain.Entities;
using SnackBar.Domain.Repositories;
using System.Collections.Generic;

namespace SnackBar.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SnackController : ControllerBase
    {
        private readonly ISnackRepository _snackRepository;

        public SnackController(ISnackRepository snackRepository)
        {
            _snackRepository = snackRepository;
        }

        [HttpGet]
        public IEnumerable<Snack> GetAll()
        {
            var snacks = _snackRepository.GetAll();
            return snacks;
        }
    }
}
