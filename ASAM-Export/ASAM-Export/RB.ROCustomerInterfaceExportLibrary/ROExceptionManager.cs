using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RB.ROCustomerInterfaceExportLibrary
{
    [Serializable]
    public class CQLoginExcption : Exception
    {
        public CQLoginExcption() { }
        public CQLoginExcption(string message) : base(message) { }
        public CQLoginExcption(string message, Exception inner) : base(message, inner) { }
        protected CQLoginExcption(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class InvalidExchangeFormatException : Exception
    {
        public InvalidExchangeFormatException() { }
        public InvalidExchangeFormatException(string message) : base(message) { }
        public InvalidExchangeFormatException(string message, Exception inner) : base(message, inner) { }
        protected InvalidExchangeFormatException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class InterfaceConfigNotFoundException : Exception
    {
        public InterfaceConfigNotFoundException() { }
        public InterfaceConfigNotFoundException(string message) : base(message) { }
        public InterfaceConfigNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected InterfaceConfigNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class IMFRulesFileNotFoundFileException : Exception
    {
        public IMFRulesFileNotFoundFileException() { }
        public IMFRulesFileNotFoundFileException(string message) : base(message) { }
        public IMFRulesFileNotFoundFileException(string message, Exception inner) : base(message, inner) { }
        protected IMFRulesFileNotFoundFileException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class IMRuleFileLoadingException : Exception
    {
        public IMRuleFileLoadingException() { }
        public IMRuleFileLoadingException(string message) : base(message) { }
        public IMRuleFileLoadingException(string message, Exception inner) : base(message, inner) { }
        protected IMRuleFileLoadingException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ProcessAllRulesException : Exception
    {
        public ProcessAllRulesException() { }
        public ProcessAllRulesException(string message) : base(message) { }
        public ProcessAllRulesException(string message, Exception inner) : base(message, inner) { }
        protected ProcessAllRulesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ProcessCommonRulesException : Exception
    {
        public ProcessCommonRulesException() { }
        public ProcessCommonRulesException(string message) : base(message) { }
        public ProcessCommonRulesException(string message, Exception inner) : base(message, inner) { }
        protected ProcessCommonRulesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ProcessIMFRuleException : Exception
    {
        public ProcessIMFRuleException() { }
        public ProcessIMFRuleException(string message) : base(message) { }
        public ProcessIMFRuleException(string message, Exception inner) : base(message, inner) { }
        protected ProcessIMFRuleException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class InvalidRORecordtypeException : Exception
    {
        public InvalidRORecordtypeException() { }
        public InvalidRORecordtypeException(string message) : base(message) { }
        public InvalidRORecordtypeException(string message, Exception inner) : base(message, inner) { }
        protected InvalidRORecordtypeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class IMFXPATHMissingException : Exception
    {
        public IMFXPATHMissingException() { }
        public IMFXPATHMissingException(string message) : base(message) { }
        public IMFXPATHMissingException(string message, Exception inner) : base(message, inner) { }
        protected IMFXPATHMissingException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
    [Serializable]
    public class OperatorNotImplementedException : Exception
    {
        public OperatorNotImplementedException() { }
        public OperatorNotImplementedException(string message) : base(message) { }
        public OperatorNotImplementedException(string message, Exception inner) : base(message, inner) { }
        protected OperatorNotImplementedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
    [Serializable]
    public class KeyNotFoundInConfigFileException : Exception
    {
        public KeyNotFoundInConfigFileException() { }
        public KeyNotFoundInConfigFileException(string message) : base(message) { }
        public KeyNotFoundInConfigFileException(string message, Exception inner) : base(message, inner) { }
        protected KeyNotFoundInConfigFileException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }


    [Serializable]
    public class ExternalIDMissingException : Exception
    {
        public ExternalIDMissingException() { }
        public ExternalIDMissingException(string message) : base(message) { }
        public ExternalIDMissingException(string message, Exception inner) : base(message, inner) { }
        protected ExternalIDMissingException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class LockRecordException : Exception
    {
        public LockRecordException() { }
        public LockRecordException(string message) : base(message) { }
        public LockRecordException(string message, Exception inner) : base(message, inner) { }
        protected LockRecordException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
