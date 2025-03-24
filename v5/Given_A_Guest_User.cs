namespace Feature.PasswordValidator
{
    public class Given_A_Guest_User : Given_A_User_Base
    {
        public Given_A_Guest_User() : base("123456", UserType.Guest) { }

        [Trait("When", "Password Is Long Enough")]
        [Fact(DisplayName = "Then Validation Should Pass")]
        public void Password_Is_Long_EnoughTest()
        {
            When_The_Password_Is_Long_Enough();
            ThenValidationShouldPass();
        }

        private void ThenValidationShouldPass()
        {
            Assert.True(_result);
        }

        private void When_The_Password_Is_Long_Enough()
        {
            ValidatePassword("123456");
        }
    }
}