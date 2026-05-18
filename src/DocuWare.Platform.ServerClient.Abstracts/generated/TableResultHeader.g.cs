using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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

        public ItemChoiceType GetItemChoiceType() => (ItemChoiceType)(Obj.GetItemChoiceType());
    }
}
