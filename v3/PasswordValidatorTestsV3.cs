namespace Feature.PasswordValidator
{
    public class PasswordValidatorTestsV3
    {
        private readonly PasswordValidatorV3 _validator = new PasswordValidatorV3();
        [Fact]
        public void ShouldFail_WhenPasswordIsTooShort()
        {
            Assert.False(_validator.IsValid("Short1", false,false));
        }

        [Fact]
        public void ShouldFail_WhenPasswordHasNoUppercase()
        {
            Assert.False(_validator.IsValid("nouppercase1", false, false));
        }

        [Fact]
        public void ShouldFail_WhenPasswordHasNoDigit()
        {
            Assert.False(_validator.IsValid("NoDigitHere", false, false));
        }

        [Fact]
        public void ShouldPass_WhenPasswordMeetsCriteria()
        {
            Assert.True(_validator.IsValid("ValidPass1", false, false));
        }

        [Fact]
        public void Guest_ShouldFail_WhenPasswordIsTooShort()
        {
            Assert.False(_validator.IsValid("12345", true, false));
        }

        [Fact]
        public void Guest_ShouldPass_WhenPasswordIsLongEnough()
        {
            Assert.True(_validator.IsValid("123456", true, false));
        }
        
        [Fact]
        public void Admin_ShouldFail_WhenPasswordLacksSpecialCharacter()
        {
            Assert.False(_validator.IsValid("AdminPass1", false, true));
        }

        [Fact]
        public void Admin_ShouldPass_WhenPasswordMeetsCriteria()
        {
            Assert.True(_validator.IsValid("Admin@123", false, true));
        }
    }

    
}