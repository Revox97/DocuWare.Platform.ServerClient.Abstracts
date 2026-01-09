using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableResultHeader(DocuWare.Platform.ServerClient.TableResultHeader obj) : ITableResultHeader
    {
        internal DocuWare.Platform.ServerClient.TableResultHeader Obj { get; } = obj;

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public string FieldLabel
        {
            get => Obj.FieldLabel;
            set => Obj.FieldLabel = value;
        }

        public TableResultFieldKind Kind
        {
            get => (TableResultFieldKind)Obj.Kind;
            set => Obj.Kind = (DocuWare.Platform.ServerClient.TableResultFieldKind)value;
        }

        public bool IsDocumentName
        {
            get => Obj.IsDocumentName;
            set => Obj.IsDocumentName = value;
        }

		public override string ToString() => Obj.ToString();

		public ItemChoiceType GetItemChoiceType() => Obj.GetItemChoiceType();
    }
}
