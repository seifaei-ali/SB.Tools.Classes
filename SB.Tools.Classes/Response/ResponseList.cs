using System.Collections.Generic;

namespace SB.Tools.Classes.Response
{
    public class ResponseList<T> : ResponseBase
    {
        public List<T> ObjectList { get; set; }
    }
}
