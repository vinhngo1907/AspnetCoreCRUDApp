using Microsoft.AspNetCore.Identity;

namespace AspnetCoreCRUDApp.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}