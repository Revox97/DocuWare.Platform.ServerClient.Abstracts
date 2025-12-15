using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFields(SDK.DocumentIndexFields obj) : IDocumentIndexFields
    {
        internal SDK.DocumentIndexFields Obj { get; } = obj;

		public IDocumentIndexField Item
		{
			get => new DocumentIndexField(Obj.Item);
			set => Obj.Item = ((DocumentIndexField)value).Obj;
		}

		public List<IDocumentIndexField> Field
		{
			get => Obj.Field.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
			set => Obj.Field = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
		}
    }
}
