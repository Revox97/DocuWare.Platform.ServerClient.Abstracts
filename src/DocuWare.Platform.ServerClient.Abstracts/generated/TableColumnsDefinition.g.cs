using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableColumnsDefinition(DocuWare.Platform.ServerClient.TableColumnsDefinition obj) : ITableColumnsDefinition
    {
        internal DocuWare.Platform.ServerClient.TableColumnsDefinition Obj { get; } = obj;

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

        public TableColumnValueTypeEnum ColumnValueType
        {
            get => (TableColumnValueTypeEnum)Obj.ColumnValueType;
            set => Obj.ColumnValueType = (DocuWare.Platform.ServerClient.TableColumnValueTypeEnum)value;
        }

        public bool Mandatory
        {
            get => Obj.Mandatory;
            set => Obj.Mandatory = value;
        }
    }
}
