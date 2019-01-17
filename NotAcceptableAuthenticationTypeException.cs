using System;
using System.Runtime.Serialization;

[Serializable]
internal class NotAcceptableAuthenticationTypeException : Exception {
    public NotAcceptableAuthenticationTypeException() {
    }

    public NotAcceptableAuthenticationTypeException(string message) : base(message) {
    }

    public NotAcceptableAuthenticationTypeException(string message, Exception innerException) : base(message, innerException) {
    }

    protected NotAcceptableAuthenticationTypeException(SerializationInfo info, StreamingContext context) : base(info, context) {
    }
}