using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnOptions(SDK.ColumnOptions obj) : IColumnOptions
    {
        internal SDK.ColumnOptions Obj { get; } = obj;

		public Object Item
		{
			get => Obj.Item;
			set => Obj.Item = value;
		}
    }
}
