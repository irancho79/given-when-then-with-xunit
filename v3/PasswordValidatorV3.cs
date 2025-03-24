namespace Feature.PasswordValidator
{
    public class PasswordValidatorV3
    {
        public bool IsValid(string password, bool isGuest, bool isAdmin)
        {
            if (isGuest)
            {
                return password.Length >= 6;
            }

            if (isAdmin)
            {
                return password.Length >= 8 &&
                       password.Any(char.IsUpper) &&
                       password.Any(char.IsDigit) &&
                       password.Any(char.IsPunctuation);
            }

            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }
    }
}