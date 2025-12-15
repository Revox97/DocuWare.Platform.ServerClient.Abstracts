using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountPlusValue(SDK.CountPlusValue obj) : ICountPlusValue
    {
        internal SDK.CountPlusValue Obj { get; } = obj;

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
