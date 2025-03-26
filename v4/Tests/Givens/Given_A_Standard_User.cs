namespace Feature.PasswordValidator
{
    public class Given_A_Standard_User : ValidationTestBase
    {
        public Given_A_Standard_User() : base("ValidPass1", UserType.Standard) { }

        [Trait("When", "Password Is Too Short")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Is_Too_ShortTest()
        {
            When_The_Password_Is_Too_Short();
            ThenValidationFail();
        }

        private void When_The_Password_Is_Too_Short()
        {
            ValidatePassword("Short1");
        }

        [Trait("When", "Password Meets Criteria")]
        [Fact(DisplayName = "Then Validation Should Pass")]
        public void Password_Meets_CriteriaTest()
        {
            When_The_Password_Meets_Criteria();
            ThenValidationPass();
        }

        private void When_The_Password_Meets_Criteria()
        {
            ValidatePassword("ValidPass1");
        }

        [Trait("When", "Password Has No Uppercase")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Has_No_UppercaseTest()
        {
            When_The_Password_Has_No_Uppercase();
            ThenValidationFail();
        }

        private void When_The_Password_Has_No_Uppercase()
        {
            ValidatePassword("nouppercase1");
        }

        [Trait("When", "Password Has No Digit")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Has_No_DigitTest()
        {
            When_The_Password_Has_No_Digit();
            ThenValidationFail();
        }

        private void When_The_Password_Has_No_Digit()
        {
            ValidatePassword("NoDigitHere");
        }
    }
}