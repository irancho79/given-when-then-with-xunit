namespace Feature.PasswordValidator
{
    public class Given_An_Admin_User : Given_A_User_Base
    {
        public Given_An_Admin_User() : base("AdminPass1", UserType.Admin)
        {
        }

        [Trait("When", "Password Lacks Special Character")]
        [Fact(DisplayName = "Then Validation Fail")]
        public void Password_Lacks_Special_CharacterTest()
        {
            When_The_Password_Lacks_Special_Character();
            ThenValidationFail();
        }

        private void ThenValidationFail()
        {
            Assert.False(_result);
        }

        private void When_The_Password_Lacks_Special_Character()
        {
            ValidatePassword("AdminPass1");
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
            ValidatePassword("Admin@123");
        }
    }
}