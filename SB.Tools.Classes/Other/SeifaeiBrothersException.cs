using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public enum ExceptionType
    {
        UnNown,
        Sql,
        DataValidation,
        Socket

    }
    public static class SeifaeiBrothersException
    {

        public const string cntKeyNameExceptionID = "SeifaeiBrothersExceptionID";
        public const string cntKeyNameCoomandTextForDBException = "CommandText";
        public const string cntKeyExceptionType = "ExceptionType";

        public static Exception CreateException(Guid id, string message, Exception innerException)
        {
            Exception newEx = new Exception(message, innerException);
            newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, id);
            return newEx;
        }

        public static Exception CreateException(string exceptionCode, string message, Exception innerException)
        {
            Exception newEx = new Exception(message, innerException);
            newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, exceptionCode);
            return newEx;
        }

        public static Exception CreateException(string exceptionCode, string message, ExceptionType exceptionType, Exception innerException)
        {
            Exception newEx = new Exception(message, innerException);
            newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, exceptionCode);
            newEx.Data.Add(SeifaeiBrothersException.cntKeyExceptionType, exceptionType);
            return newEx;            
        }

        public static string ToFullString(this Exception source)
        {
            string returnValue = string.Empty;
            try
            {
                Exception ex = source;
                while (true)
                {
                    returnValue += ex.Message;
                    if (ex.Data.Contains(cntKeyNameExceptionID))
                    {
                        returnValue += Environment.NewLine + "ExceptionID = " + ex.Data[cntKeyNameExceptionID].ToString();
                    }

                    if (ex.Data.Contains(ex.Data.Contains(cntKeyNameCoomandTextForDBException)))
                    {
                        returnValue += Environment.NewLine + "Command Text = " + ex.Data[cntKeyNameCoomandTextForDBException].ToString();
                    }

                    if (ex.InnerException != null)
                    {
                        returnValue += Environment.NewLine + "-----------------------------------------------------------" + Environment.NewLine;
                        ex = ex.InnerException;
                    }
                    else
                    {
                        returnValue += Environment.NewLine + ex.ToString();
                        break;
                    }
                }

            }
            catch { }
            return returnValue;
        }
    }
}
