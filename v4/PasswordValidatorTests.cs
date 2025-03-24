namespace Feature.PasswordValidator
{
    public class PasswordValidatorTestsV4
    {
        private readonly PasswordValidator _validator = new PasswordValidator();

        [Fact]
        public void Standard_ShouldFail_WhenPasswordIsTooShort()
        {
            var request = new PasswordValidationRequest("Short1", UserType.Standard);
            Assert.False(_validator.IsValid(request));
        }

        [Fact]
        public void Standard_ShouldPass_WhenPasswordMeetsCriteria()
        {
            var request = new PasswordValidationRequest("ValidPass1", UserType.Standard);
            Assert.True(_validator.IsValid(request));
        }

        [Fact]
        public void Guest_ShouldPass_WhenPasswordIsLongEnough()
        {
            var request = new PasswordValidationRequest("123456", UserType.Guest);
            Assert.True(_validator.IsValid(request));
        }

        [Fact]
        public void Admin_ShouldFail_WhenPasswordLacksSpecialCharacter()
        {
            var request = new PasswordValidationRequest("AdminPass1", UserType.Admin);
            Assert.False(_validator.IsValid(request));
        }

        [Fact]
        public void Admin_ShouldPass_WhenPasswordMeetsCriteria()
        {
            var request = new PasswordValidationRequest("Admin@123", UserType.Admin);
            Assert.True(_validator.IsValid(request));
        }
    }

}