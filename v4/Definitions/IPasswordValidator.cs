namespace Feature.PasswordValidator
{
    public interface IPasswordValidator
    {
        bool IsValid(PasswordValidationRequest request);
    }
}