namespace Feature.PasswordValidator
{
    public class PasswordValidatorTestsV2
    {
        private readonly PasswordValidatorV2 _validator = new PasswordValidatorV2();

        [Fact]
        public void ShouldFail_WhenPasswordIsTooShort()
        {
            Assert.False(_validator.IsValid("Short1", false));
        }

        [Fact]
        public void ShouldFail_WhenPasswordHasNoUppercase()
        {
            Assert.False(_validator.IsValid("nouppercase1", false));
        }

        [Fact]
        public void ShouldFail_WhenPasswordHasNoDigit()
        {
            Assert.False(_validator.IsValid("NoDigitHere", false));
        }

        [Fact]
        public void ShouldPass_WhenPasswordMeetsCriteria()
        {
            Assert.True(_validator.IsValid("ValidPass1", false));
        }

        [Fact]
        public void Guest_ShouldFail_WhenPasswordIsTooShort()
        {
            Assert.False(_validator.IsValid("12345", true));
        }

        [Fact]
        public void Guest_ShouldPass_WhenPasswordIsLongEnough()
        {
            Assert.True(_validator.IsValid("123456", true));
        }
    }
}