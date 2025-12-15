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

		public TableResultFieldKind Kind
		{
			get => new ableResultFieldKind(Obj.Kind);
			set => Obj.Kind = ((ableResultFieldKind)value).Obj;
		}

		public bool IsDocumentName
		{
			get => Obj.IsDocumentName;
			set => Obj.IsDocumentName = value;
		}

		public async string ToString() => Obj.ToString();
        public ItemChoiceType GetItemChoiceType() => new temChoiceType(Obj.GetItemChoiceType());

    }
}
