namespace Feature.PasswordValidator
{
    public enum UserType
    {
        Standard,
        Guest,
        Admin
    }

    public class PasswordValidationRequest
    {
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public PasswordValidationRequest(string password, UserType userType)
        {
            Password = password;
            UserType = userType;
        }
    }
}