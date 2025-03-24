namespace Feature.PasswordValidator
{
    public class PasswordValidatorV2
    {
        public bool IsValid(string password, bool isGuest)
        {
            if (isGuest)
            {
                return password.Length >= 6;
            }

            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }
    }
}