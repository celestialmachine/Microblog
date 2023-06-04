using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;  // for NotMapped

namespace Microblog.Models
{
    public class User : IdentityUser
    {
    }
}
