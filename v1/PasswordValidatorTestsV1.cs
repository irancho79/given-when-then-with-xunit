
namespace Feature.PasswordValidator
{
    public class PasswordValidatorTestsV1
    {
        private readonly PasswordValidatorV1 _validator = new PasswordValidatorV1();

        [Fact]
        public void ShouldFail_WhenPasswordIsTooShort()
        {
            Assert.False(_validator.IsValid("Short1"));
        }

        [Fact]
        public void ShouldFail_WhenPasswordHasNoUppercase()
        {
            Assert.False(_validator.IsValid("nouppercase1"));
        }

        [Fact]
        public void ShouldFail_WhenPasswordHasNoDigit()
        {
            Assert.False(_validator.IsValid("NoDigitHere"));
        }

        [Fact]
        public void ShouldPass_WhenPasswordMeetsCriteria()
        {
            Assert.True(_validator.IsValid("ValidPass1"));
        }
    }
}