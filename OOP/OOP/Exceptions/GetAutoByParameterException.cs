using System;

namespace OOP.Exceptions
{
    [Serializable]
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException() : base("Unable to find a model with such parameter.") { }
        public GetAutoByParameterException(string message, Exception inner) : base(message, inner) { }
        protected GetAutoByParameterException(System.Runtime.Serialization.SerializationInfo info,
                                              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}