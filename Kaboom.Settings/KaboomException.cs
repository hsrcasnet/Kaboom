using System;

namespace Kaboom.Settings
{
    internal class KaboomException : Exception
    {
        public KaboomException(string message) : base(message)
        {
        }

        public KaboomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}