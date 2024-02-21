using System;

namespace SalesWebMvc.Services.Execeptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException (string message) : base(message)
        {
        }
    }
}
