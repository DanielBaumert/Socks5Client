using System;
using System.Runtime.Serialization;

[Serializable]
internal class SocksGeneralFailureException : Exception {
    public SocksGeneralFailureException() {
    }

    public SocksGeneralFailureException(string message) : base(message) {
    }

    public SocksGeneralFailureException(string message, Exception innerException) : base(message, innerException) {
    }

    protected SocksGeneralFailureException(SerializationInfo info, StreamingContext context) : base(info, context) {
    }
}