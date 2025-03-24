namespace Feature.PasswordValidator
{
    public class PasswordValidatorV1
    {
        public bool IsValid(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }
    }
}