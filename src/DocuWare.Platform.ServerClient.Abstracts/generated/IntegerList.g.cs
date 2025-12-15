using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntegerList(SDK.IntegerList obj) : IIntegerList
    {
        internal SDK.IntegerList Obj { get; } = obj;

		public List<int> Int
		{
			get => Obj.Int;
			set => Obj.Int = value;
		}
    }
}
