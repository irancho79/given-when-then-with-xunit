namespace Feature.PasswordValidator
{
    public class GuestPasswordValidator : IPasswordValidatorStrategy
    {
        public bool IsValid(PasswordValidationRequest request)
        {
            return request.Password.Length >= 6;
        }
    }
}