﻿using System;
using System.Runtime.Serialization;

namespace AngleSharp.Diffing.Strategies.ElementStrategies
{
    [Serializable]
    public class DiffMatchSelectorReturnedTooManyResultsException : Exception
    {
        public DiffMatchSelectorReturnedTooManyResultsException()
        {
        }

        public DiffMatchSelectorReturnedTooManyResultsException(string message) : base(message)
        {
        }

        public DiffMatchSelectorReturnedTooManyResultsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DiffMatchSelectorReturnedTooManyResultsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}