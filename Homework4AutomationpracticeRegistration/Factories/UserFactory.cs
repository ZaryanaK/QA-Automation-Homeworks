using Homework4AutomationpracticeRegistration.Models;


namespace Homework4AutomationpracticeRegistration.Factories
{
    public static class UserFactory
    {
        public static AutomationPracticeModel CreateValidUser()
        {
            return new AutomationPracticeModel
            {
                FirstNameYPISection = "Ivan",
                LastNameYPISection = "Petrov",
                Password = "1234567",
                Address = "Ivan Vazov 15",
                City = "Veliko Turnovo",
                Zip = "12345",
                MobilePhone = "0888777666",  
                AddressAlias = "Ivan Vazov 15",
            };
        }

        //public static AutomationPracticeModel CreateUserWithoutFirstName()
        //{
        //    return new AutomationPracticeModel
        //    {               
        //        LastNameYPISection = "Petrov",
        //        Password = "1234567",
        //        FisrtNameYASection = "Gosho",
        //        Address = "Ivan Vazov 15",
        //        City = "Veliko Turnovo",
        //        Zip = "12345",
        //        MobilePhone = "0888777666",
        //        AddressAlias = "Ivan Vazov 15",
        //    };
        //}

        //public static AutomationPracticeModel CreateUserWithoutLastName()
        //{
        //    return new AutomationPracticeModel
        //    {
        //        FirstNameYPISection = "Ivan",
        //        Password = "1234567",
        //        LastNameYASection = "Georgiev",
        //        Address = "Ivan Vazov 15",
        //        City = "Veliko Turnovo",
        //        Zip = "12345",
        //        MobilePhone = "0888777666",
        //        AddressAlias = "Ivan Vazov 15",
        //    };
        //}
    }
}
