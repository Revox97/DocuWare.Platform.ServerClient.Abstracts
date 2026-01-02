using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnSortOrder(DocuWare.Platform.ServerClient.ColumnSortOrder obj) : IColumnSortOrder
    {
        internal DocuWare.Platform.ServerClient.ColumnSortOrder Obj { get; } = obj;

        public string ColumnId
        {
            get => Obj.ColumnId;
            set => Obj.ColumnId = value;
        }

        public SortDirection Direction
        {
            get => (SortDirection)Obj.Direction;
            set => Obj.Direction = (DocuWare.Platform.ServerClient.SortDirection)value;
        }
    }
}
