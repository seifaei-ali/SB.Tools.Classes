using System;


namespace SB.Tools.Classes.Response
{
    public class ResponseBase
    {
        public bool Success
        {
            get { return Exception == null; }
        }
        public Exception Exception { get; set; }
    }
}
