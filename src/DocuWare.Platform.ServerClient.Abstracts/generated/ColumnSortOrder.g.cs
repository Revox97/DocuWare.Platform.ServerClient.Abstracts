using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnSortOrder(SDK.ColumnSortOrder obj) : IColumnSortOrder
    {
        internal SDK.ColumnSortOrder Obj { get; } = obj;

		public string ColumnId
		{
			get => Obj.ColumnId;
			set => Obj.ColumnId = value;
		}

		public SortDirection Direction
		{
			get => new ortDirection(Obj.Direction);
			set => Obj.Direction = ((ortDirection)value).Obj;
		}
    }
}
