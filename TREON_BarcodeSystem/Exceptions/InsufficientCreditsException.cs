﻿using System;
using System.Runtime.Serialization;

namespace TREON_BarcodeSystem.Classes
{
    public class InsufficientCreditsException : Exception
    {
        public InsufficientCreditsException()
        {
        }

        public InsufficientCreditsException(string message) : base(message)
        {
        }

        public InsufficientCreditsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InsufficientCreditsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}