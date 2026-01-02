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

        public DocuWare.Platform.ServerClient.SortDirection Direction
        {
            get => Obj.Direction;
            set => Obj.Direction = value;
        }
    }
}
