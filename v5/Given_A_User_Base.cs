namespace Feature.PasswordValidator
{
    public abstract class Given_A_User_Base
    {
        protected readonly PasswordValidationRequest request;
        protected bool _result;
        protected readonly IPasswordValidator _validator;

        protected Given_A_User_Base(string password, UserType userType)
        {
            request = new PasswordValidationRequest(password, userType);
            _validator = new PasswordValidator();
        }

        protected void ValidatePassword(string password)
        {
            request.Password = password;
            _result = _validator.IsValid(request);
        }
    }
}
