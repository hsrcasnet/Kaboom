using System;

namespace Kaboom.Settings
{
    public class KaboomException : Exception
    {
        public KaboomException(string message) : base(message)
        {
        }

        public KaboomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}