namespace SB.Tools.Classes.Response
{
    public class Response3Obj<T1, T2, T3> : ResponseBase
    {
        public T1 Object1 { get; set; }

        public T2 Object2 { get; set; }

        public T3 Object3 { get; set; }
    }
}
