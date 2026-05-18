using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
            get => (SortDirection)Obj.Direction;
            set => Obj.Direction = (DocuWare.Platform.ServerClient.SortDirection)value;
        }
    }
}
