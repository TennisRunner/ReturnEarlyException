using System;

namespace ReturnEarly
{
    public class ReturnEarlyException : Exception
    {
        public ReturnEarlyException(string message) : base(message)
        {

        }
    }
}
