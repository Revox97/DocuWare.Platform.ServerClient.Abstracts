using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class KeyValuePair(SDK.KeyValuePair obj) : IKeyValuePair
    {
        internal SDK.KeyValuePair Obj { get; } = obj;

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public string Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}
    }
}
