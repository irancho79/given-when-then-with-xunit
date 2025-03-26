namespace Feature.PasswordValidator
{
    public abstract class ValidationTestBase
    {
        protected readonly PasswordValidationRequest request;
        protected bool _result;
        protected readonly IPasswordValidator _validator;

        protected ValidationTestBase(string password, UserType userType)
        {
            request = new PasswordValidationRequest(password, userType);
            _validator = new PasswordValidator();
        }

        protected void ValidatePassword(string password)
        {
            request.Password = password;
            _result = _validator.IsValid(request);
        }

        protected void ThenValidationFail()
        {
            Assert.False(_result);
        }

        protected void ThenValidationPass()
        {
            Assert.True(_result);
        }
    }
}
