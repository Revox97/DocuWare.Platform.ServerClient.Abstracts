using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountResultItem(SDK.CountResultItem obj) : ICountResultItem
    {
        internal SDK.CountResultItem Obj { get; } = obj;

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public int Count
		{
			get => Obj.Count;
			set => Obj.Count = value;
		}
    }
}
