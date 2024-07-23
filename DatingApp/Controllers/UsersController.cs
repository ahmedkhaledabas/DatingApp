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
        public async Task<ActionResult<IEnumerable<AppUserDTO>>> GetUsers()
        {
            return await appUserService.GetAppUsers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUserDTO>> GetUser(int id)
        {
            return await appUserService.GetAppUser(id);
        }


    }
}
