using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Luck.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        [Display(Name = "Аты")]
        [Required]
        public string Aty { get; set; }

        [Display(Name = "Тегі")]
        [Required]
        public string Tegi { get; set; }

        [Display(Name = "Әкесінің аты")]
        [Required]
        public string Akesinin_aty { get; set; }

        [Display(Name = "Туған күні")]
        [Required]
        public string Tugan_kuni { get; set; }

        [Display(Name = "Мекен-жайы")]
        [Required]
        public string Meken_zhai { get; set; }

        [Display(Name = "Телефон номері")]
        [Required]
        public string Tel_nomeri { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole(): base() { }

        public ApplicationRole(string roleName) : base(roleName) { }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

       
    }
}