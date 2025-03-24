namespace Feature.PasswordValidator
{
    public class PasswordValidator : IPasswordValidator
    {
        private readonly Dictionary<UserType, IPasswordValidatorStrategy> _strategies;

        public PasswordValidator()
        {
            _strategies = new Dictionary<UserType, IPasswordValidatorStrategy>
        {
            { UserType.Standard, new StandardPasswordValidator() },
            { UserType.Guest, new GuestPasswordValidator() },
            { UserType.Admin, new AdminPasswordValidator() }
        };
        }

        public bool IsValid(PasswordValidationRequest request)
        {
            return _strategies[request.UserType].IsValid(request);
        }
    }
}