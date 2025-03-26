namespace Feature.PasswordValidator
{
    public class Given_A_Guest_User : ValidationTestBase
    {
        public Given_A_Guest_User() : base("123456", UserType.Guest) { }

        [Trait("When", "Password Is Long Enough")]
        [Fact(DisplayName = "Then Validation Should Pass")]
        public void Password_Is_Long_EnoughTest()
        {
            When_The_Password_Is_Long_Enough();
            ThenValidationPass();
        }

        private void When_The_Password_Is_Long_Enough()
        {
            ValidatePassword("123456");
        }

        [Trait("When", "Password Is Too Short")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Is_Too_ShortTest()
        {
            When_The_Password_Is_Too_Short();
            ThenValidationFail();
        }

        private void When_The_Password_Is_Too_Short()
        {
            ValidatePassword("12345");
        }

    }
}