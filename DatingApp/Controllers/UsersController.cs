namespace DatingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAppUserService appUserService;

        public UsersController(IAppUserService appUserService)
        {
            this.appUserService = appUserService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<AppUserDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AppUserDTO>>> GetUsers(CancellationToken cancellationToken)
        {
            var users = await appUserService.GetAppUsers(cancellationToken);
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(AppUserDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AppUserDTO>> GetUser(int id, CancellationToken cancellationToken)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var user = await appUserService.GetAppUser(id, cancellationToken);
            return user is null ? NotFound() : Ok(user);
        }
    }
}
