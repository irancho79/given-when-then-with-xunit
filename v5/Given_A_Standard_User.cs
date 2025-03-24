namespace Feature.PasswordValidator
{
    public class Given_A_Standard_User : Given_A_User_Base
    {
        public Given_A_Standard_User() : base("ValidPass1", UserType.Standard) { }

        [Trait("When", "Password Is Too Short")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Is_Too_ShortTest()
        {
            When_The_Password_Is_Too_Short();
            ThenValidationShouldFail();
        }

        private void ThenValidationShouldFail()
        {
            Assert.False(_result);
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
            ThenValidationShouldPass();
        }

        private void ThenValidationShouldPass()
        {
            Assert.True(_result);
        }

        private void When_The_Password_Meets_Criteria()
        {
            ValidatePassword("ValidPass1");
        }
    }
}