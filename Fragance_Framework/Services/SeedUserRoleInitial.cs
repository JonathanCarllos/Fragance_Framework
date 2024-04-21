using Microsoft.AspNetCore.Identity;

namespace Fragance_Framework.Services
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInitial(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedRolesAsync()
        {
            if (!await _roleManager.RoleExistsAsync("User"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

                IdentityResult roleResult = await _roleManager.CreateAsync(role);
            }


            //if (!await _roleManager.RoleExistsAsync("Gerente"))
            //{
            //    IdentityRole role = new IdentityRole();
            //    role.Name = "Gerente";
            //    role.NormalizedName = "GERENTE";
            //    role.ConcurrencyStamp = Guid.NewGuid().ToString();

            //    IdentityResult roleResult = await _roleManager.CreateAsync(role);
            //}
        }

        public async Task SeedUsersAsync()
        {
            if (await _userManager.FindByEmailAsync("usuario@localhost.com") == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "usuario@localhost.com";
                user.Email = "usuario@localhost.com";
                user.NormalizedUserName = "USUARIO@LOCALHOST.COM";
                user.NormalizedEmail = "USUARIO@LOCALHOST.COM";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;

                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "Aezakmi@2024");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                }
            }

            if (await _userManager.FindByEmailAsync("admin@localhost.com") == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "admin@localhost.com";
                user.Email = "admin@localhost.com";
                user.NormalizedUserName = "ADMIN@LOCALHOST.COM";
                user.NormalizedEmail = "ADMIN@LOCALHOST.COM";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;

                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "Aezakmi@2024");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }

            //if (await _userManager.FindByEmailAsync("gerente@localhost.com") == null)
            //{
            //    IdentityUser user = new IdentityUser();
            //    user.UserName = "gerente@localhost.com";
            //    user.Email = "gerente@localhost.com";
            //    user.NormalizedUserName = "GERENTE@LOCALHOST.COM";
            //    user.NormalizedEmail = "GERENTE@LOCALHOST.COM";
            //    user.EmailConfirmed = true;
            //    user.LockoutEnabled = false;

            //    user.SecurityStamp = Guid.NewGuid().ToString();

            //    IdentityResult result = await _userManager.CreateAsync(user, "Aezakmi@2024");

            //    if (result.Succeeded)
            //    {
            //        await _userManager.AddToRoleAsync(user, "Gerente");
            //    }
            //}
        }
    }
}
