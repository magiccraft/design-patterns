
public class UserProfileBuilder : IUserProfileBuilder
{
     UserProfile _userProfile = new UserProfile();

    public UserProfile Build()
    {
        return _userProfile;
    }


    public IUserProfileBuilder SetAddress(string address)
    {
        _userProfile.Address = address;
        return this;
    }

    public IUserProfileBuilder SetEmail(string email)
    {
        _userProfile.Email = email;
        return this;
    }

    public IUserProfileBuilder SetName(string name)
    {
        _userProfile.Name = name;
        return this;
    }

    public IUserProfileBuilder SetPhoneNumber(string phoneNumber)
    {
        _userProfile.PhoneNumber = phoneNumber;
        return this;
    }
}