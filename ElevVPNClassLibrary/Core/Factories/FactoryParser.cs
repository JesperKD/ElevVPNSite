using System;

namespace ElevVPNClassLibrary.Core.Factories
{
    public abstract class FactoryParser
    {
        protected T ParseValue<T>(object value)
        {
            if (value is T parsedValue)
            {
                return parsedValue;
            }

            throw new ArgumentException($"Value wasn't of type {typeof(T)}");
        }
    }
}
