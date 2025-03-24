namespace Feature.PasswordValidator
{
    public interface IPasswordValidatorStrategy
    {
        bool IsValid(PasswordValidationRequest request);
    }
}