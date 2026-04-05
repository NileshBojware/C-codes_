using System;

namespace ExceptionPrograms
{
    class MyException : Exception
    {
        public MyException(string msg) : base(msg) {}
    }

    class CustomExceptionDemo
    {
        static void Main()
        {
            try
            {
                throw new MyException("Custom Error!");
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}