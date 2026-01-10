using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Column(DocuWare.Platform.ServerClient.Column obj) : IColumn
    {
        internal DocuWare.Platform.ServerClient.Column Obj { get; } = obj;

        public IColumnOptions ColumnOptions
        {
            get => new ColumnOptions(Obj.ColumnOptions);
            set => Obj.ColumnOptions = ((ColumnOptions)value).Obj;
        }

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

        public ColumnValueTypeEnum ColumnValueType
        {
            get => (ColumnValueTypeEnum)Obj.ColumnValueType;
            set => Obj.ColumnValueType = (DocuWare.Platform.ServerClient.ColumnValueTypeEnum)value;
        }

        public ColumnTypeEnum ColumnType
        {
            get => (ColumnTypeEnum)Obj.ColumnType;
            set => Obj.ColumnType = (DocuWare.Platform.ServerClient.ColumnTypeEnum)value;
        }
    }
}
