namespace Feature.PasswordValidator
{
    public class Given_An_Admin_User : ValidationTestBase
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

        private void When_The_Password_Lacks_Special_Character()
        {
            ValidatePassword("AdminPass1");
        }

        [Trait("When", "Password Meets All Criteria")]
        [Fact(DisplayName = "Then Validation Should Pass")]
        public void Password_Meets_CriteriaTest()
        {
            When_The_Password_Meets_Criteria();
            ThenValidationPass();
        }

        private void When_The_Password_Meets_Criteria()
        {
            ValidatePassword("Admin@123");
        }

        [Trait("When", "Password Is Less Than 12 Characters")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Is_Less_Than_12_CharactersTest()
        {
            When_The_Password_Is_Less_Than_12_Characters();
            ThenValidationFail();
        }

        private void When_The_Password_Is_Less_Than_12_Characters()
        {
            ValidatePassword("Short1!");
        }

        [Trait("When", "Password Lacks Uppercase Letter")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Lacks_Uppercase_LetterTest()
        {
            When_The_Password_Lacks_Uppercase_Letter();
            ThenValidationFail();
        }

        private void When_The_Password_Lacks_Uppercase_Letter()
        {
            ValidatePassword("lowercase1!");
        }

        [Trait("When", "Password Lacks Lowercase Letter")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Lacks_Lowercase_LetterTest()
        {
            When_The_Password_Lacks_Lowercase_Letter();
            ThenValidationFail();
        }

        private void When_The_Password_Lacks_Lowercase_Letter()
        {
            ValidatePassword("UPPERCASE1!");
        }

        [Trait("When", "Password Lacks Number")]
        [Fact(DisplayName = "Then Validation Should Fail")]
        public void Password_Lacks_NumberTest()
        {
            When_The_Password_Lacks_Number();
            ThenValidationFail();
        }

        private void When_The_Password_Lacks_Number()
        {
            ValidatePassword("NoNumber!");
        }
    }
}