﻿using System;
using System.Runtime.Serialization;

[Serializable]
internal class HostUnreachableException : Exception {
    public HostUnreachableException() {
    }

    public HostUnreachableException(string message) : base(message) {
    }

    public HostUnreachableException(string message, Exception innerException) : base(message, innerException) {
    }

    protected HostUnreachableException(SerializationInfo info, StreamingContext context) : base(info, context) {
    }
}