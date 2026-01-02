using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnsDefinition(DocuWare.Platform.ServerClient.ColumnsDefinition obj) : IColumnsDefinition
    {
        internal DocuWare.Platform.ServerClient.ColumnsDefinition Obj { get; } = obj;

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
