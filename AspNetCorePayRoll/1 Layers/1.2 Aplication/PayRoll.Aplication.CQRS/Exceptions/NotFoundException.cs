using System;

namespace PayRoll.Aplication.CQRS.Exceptions
{
    public class NotFoundException: ApplicationException
    {
        public NotFoundException(string name, object key)
           : base($"Entity \"{name}\"({key}) was not found.")
        {

        }
    }
}
