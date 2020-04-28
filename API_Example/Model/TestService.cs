using System;
namespace API_Example.Model
{
    //This class is used for dependency injection
    public class TestService
    {
        public int ReturnInteger()
        {
            return 20;
        }

        public string ReturnString()
        {
            return "Test String";
        }
    }
}
