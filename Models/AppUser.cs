using Microsoft.AspNetCore.Identity;

namespace Imtahanbilet9.Models
{
    public class AppUser : IdentityUser
    {
      
            public string Email { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string UserName { get; set; }
        }
    }



