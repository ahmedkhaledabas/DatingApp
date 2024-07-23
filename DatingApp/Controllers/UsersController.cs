namespace DatingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepo usersRepo;

        public UsersController(IUsersRepo usersRepo)
        {
            this.usersRepo = usersRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUserDTO>>> GetUsers() { 
            List<AppUser> users = await usersRepo.GetUsers();
            if (users.Count > 0)
            {
                return TransformAppUser.UsersToDTOs(users);
            }
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUserDTO>> GetUser(int id)
        {
            AppUser? user = await usersRepo.GetUser(id);
            if (user is not null)
            {
                return TransformAppUser.UserToDTO(user);
            }
            return NoContent();
        }


    }
}
