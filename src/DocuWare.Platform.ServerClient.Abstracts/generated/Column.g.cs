using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Column(DocuWare.Platform.ServerClient.Column obj) : IColumn
    {
        internal DocuWare.Platform.ServerClient.Column Obj { get; } = obj;

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public DocuWare.Platform.ServerClient.ColumnValueTypeEnum ColumnValueType
        {
            get => Obj.ColumnValueType;
            set => Obj.ColumnValueType = value;
        }

        public DocuWare.Platform.ServerClient.ColumnTypeEnum ColumnType
        {
            get => Obj.ColumnType;
            set => Obj.ColumnType = value;
        }
    }
}
