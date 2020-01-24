using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Payroll_Manager.Persistence
{
    public class DataSeedingIntializer
    {
        public static async Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager,
                                                RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Manager", "Staff", "Demo" };
            foreach (var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
            // Create Admin User
            if (userManager.FindByEmailAsync("tompetty527@yahoo.co.uk").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "tompetty527@yahoo.co.uk",
                    Email = "tompetty527@yahoo.co.uk"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "GuessMe101").Result;
                if(identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            //Create Manager User
            if (userManager.FindByEmailAsync("manager@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "manager@gmail.com",
                    Email = "manager@gmail.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "GuessMe101").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }

            //Create Staff User
            if (userManager.FindByEmailAsync("staff@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "staff@gmail.com",
                    Email = "staff@gmail.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "GuessMe101").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Staff").Wait();
                }
            }
            //Create No Role User
            if (userManager.FindByEmailAsync("newStaff@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "newStaff@gmail.com",
                    Email = "newStaff@gmail.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "GuessMe101").Result;
            }
        }
    }
}
