using System;
using System.Runtime.Serialization;

[Serializable]
internal class SocksConnectionException : Exception {
    public SocksConnectionException() {
    }

    public SocksConnectionException(string message) : base(message) {
    }

    public SocksConnectionException(string message, Exception innerException) : base(message, innerException) {
    }

    protected SocksConnectionException(SerializationInfo info, StreamingContext context) : base(info, context) {
    }
}