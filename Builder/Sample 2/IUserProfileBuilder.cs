public interface IUserProfileBuilder
{
    IUserProfileBuilder SetName(string name);
    IUserProfileBuilder SetEmail(string email);
    IUserProfileBuilder SetAddress(string address);
    IUserProfileBuilder SetPhoneNumber(string phoneNumber);

    UserProfile Build();
}
