using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountPlusValue(DocuWare.Platform.ServerClient.CountPlusValue obj) : ICountPlusValue
    {
        internal DocuWare.Platform.ServerClient.CountPlusValue Obj { get; } = obj;

        public bool HasMore
        {
            get => Obj.HasMore;
            set => Obj.HasMore = value;
        }

        public bool ExceedLimit
        {
            get => Obj.ExceedLimit;
            set => Obj.ExceedLimit = value;
        }

        public int Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
