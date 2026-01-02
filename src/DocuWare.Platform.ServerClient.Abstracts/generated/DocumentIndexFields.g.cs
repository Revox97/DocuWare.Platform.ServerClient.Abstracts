using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFields(DocuWare.Platform.ServerClient.DocumentIndexFields obj) : IDocumentIndexFields
    {
        internal DocuWare.Platform.ServerClient.DocumentIndexFields Obj { get; } = obj;

        public List<IDocumentIndexField> Field
        {
            get => Obj.Field.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Field = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }
    }
}
