using System;

namespace EX16.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) 
        { 
        }
    }
}
