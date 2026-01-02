using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableResultHeader(SDK.TableResultHeader obj) : ITableResultHeader
    {
        internal SDK.TableResultHeader Obj { get; } = obj;

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

        public DocuWare.Platform.ServerClient.TableResultFieldKind Kind
        {
            get => Obj.Kind;
            set => Obj.Kind = value;
        }

        public bool IsDocumentName
        {
            get => Obj.IsDocumentName;
            set => Obj.IsDocumentName = value;
        }

		public string ToString() => Obj.ToString();

		public DocuWare.Platform.ServerClient.ItemChoiceType GetItemChoiceType() => Obj.GetItemChoiceType();
    }
}
