using System;

namespace ProductFunction
{
    public class Class1
    {
        public string GetUserName(string name)
        { 
            if(string.IsNullOrWhiteSpace(name))
            {
                return "請輸入使用者姓名!";
            }

            return $"Hi!{name}，歡迎使用";
        }

        public string ExceptionTest(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException();
            }

            return $"Hi!{name}，歡迎使用";
        }

        public string GetNewYear()
        {
            if (SystemTime.Today.Month == 1 &&
                SystemTime.Today.Day == 1)
            {
                return "Happy NEW YEAR!";
            }

            return "Today is not Holiday";
        }
    }
}
