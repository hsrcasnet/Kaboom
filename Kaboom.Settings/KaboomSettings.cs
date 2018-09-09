using System;

namespace Kaboom.Settings
{
    public static class KaboomSettings
    {
        public static string GetValue(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException(nameof(key));
            }

            return $"Value-{key}";
        }

        public static string SetValue(string key, string value)
        {
            throw new KaboomException("Kaboom!!", new KaboomException("Another nested Kaboom!!", new NullReferenceException()));
        }
    }
}
