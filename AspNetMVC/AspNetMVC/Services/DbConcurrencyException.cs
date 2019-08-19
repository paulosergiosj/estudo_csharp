using System;


namespace AspNetMVC.Services
{
    public class DbConcurrencyException :ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
