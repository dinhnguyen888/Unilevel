using Microsoft.AspNetCore.Identity;
using Unilevel.DTOs;

public class PersonalInfoService
{
    private readonly UserManager<User> _userManager;

    public PersonalInfoService(UserManager<User> userManager)
    {
        _userManager = userManager;
    }


    // doi mat khau
    public async Task<IdentityResult> ChangePasswordAsync(string userId, string currentPassword, string newPassword)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return IdentityResult.Failed(new IdentityError { Description = "User not found" });
        }

        return await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
    }


    // lay thong tin ca nhan
    public async Task<Profile> GetUserInfoAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return null; 
        }

        var profile = new Profile
        {
            UserName = user.UserName,
            PhoneNumber = user.PhoneNumber,
            Email = user.Email,
            Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault(),
            Address = user.Address, 
            Area = user.Area,  
            JoinDate = user.JoinDate,
            PathPicture = user.PathPicture
        };

        return profile;
    }



    //chinh sua thong tin ca nhan
    public async Task<IdentityResult> UpdateUserInfoAsync(string userId, Profile updatedUser)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return IdentityResult.Failed(new IdentityError { Description = "User not found" });
        }

        user.UserName = updatedUser.UserName;
        user.Email = updatedUser.Email;
        user.PhoneNumber = updatedUser.PhoneNumber;
        user.Address = updatedUser.Address;
        user.Area = updatedUser.Area;
        user.PathPicture = updatedUser.PathPicture;

        return await _userManager.UpdateAsync(user);
    }
}
