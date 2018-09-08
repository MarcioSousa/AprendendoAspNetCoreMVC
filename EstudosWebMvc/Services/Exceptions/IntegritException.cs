using System;

namespace EstudosWebMvc.Services.Exceptions
{
    public class IntegritException : ApplicationException
    {
        public IntegritException(string message) : base(message)
        {

        }
    }
}
