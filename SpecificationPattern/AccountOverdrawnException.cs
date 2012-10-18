using System;

namespace SpecificationPattern
{
    public class AccountOverdrawnException : Exception
    {
        public AccountOverdrawnException(string message) : base(message) { }
    }
}