namespace Feature.PasswordValidator
{
    public class StandardPasswordValidator : IPasswordValidatorStrategy
    {
        public bool IsValid(PasswordValidationRequest request)
        {
            var password = request.Password;
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }
    }

}