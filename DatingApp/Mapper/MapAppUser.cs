
namespace DatingApp.Mapper
{
    public class MapAppUser
    {
        public static AppUserDTO UserToDTO(AppUser user)
        {
            return new AppUserDTO
            {
                Id = user.Id,
                UserName = user.UserName
            };
        }


        public static List<AppUserDTO> UsersToDTOs(List<AppUser> users)
        {
            List<AppUserDTO>? usersDto = new List<AppUserDTO>();
            foreach (AppUser user in users)
            {
                AppUserDTO? dto = new AppUserDTO
                {
                    Id = user.Id,
                    UserName = user.UserName
                };

                usersDto.Add(dto);
            }
            return usersDto;
        }
    }
}
