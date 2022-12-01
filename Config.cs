
namespace Automation_project_v3
{
    public static class Config
    {
        public static string BaseURL = "https://testing.todorvachev.com/";
        public static class Credentials
        {
            public static class Valid
            {
                public static string UserName = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";

            }
            public static class InValid
            {
                public static class UserName
                {
                    public static string FourCharacters = "adfr";
                    public static string ThirteenCharacters = "jjbghdgdvhegfjyfk";
                }
                public static class Password
                {
                    public static string InValidFourCharacters = "4532";
                    public static string InValidThirteenCharacters = "1234567891234"; 
                }
                public static class Email
                {
                    public static string InvalidEmail = "kuyfkuy";
                }
            }
        }
        public static class AlertMessages
        {
            public static string SuccessfullLogin = "Succesful login!";
            public static string InvalidPasswordMessage = "Password should not be empty / length be between 5 to 12";
            public static string InvalidUserNameMessage = "User Id should not be empty / length be between 5 to 12";
            public static string InvalidPasswordDoNotMatch = "Passwords do not match!";
        }
        


    }
}
