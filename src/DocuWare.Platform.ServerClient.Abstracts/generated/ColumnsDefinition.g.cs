using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnsDefinition(SDK.ColumnsDefinition obj) : IColumnsDefinition
    {
        internal SDK.ColumnsDefinition Obj { get; } = obj;

        public List<IColumn> Column
        {
            get => Obj.Column.Select(x => new Column(x) as IColumn).ToList();
            set => Obj.Column = value.Select(x => ((Column)x).Obj).ToList();
        }

        public List<IColumnSortOrder> Sort
        {
            get => Obj.Sort.Select(x => new ColumnSortOrder(x) as IColumnSortOrder).ToList();
            set => Obj.Sort = value.Select(x => ((ColumnSortOrder)x).Obj).ToList();
        }
    }
}
