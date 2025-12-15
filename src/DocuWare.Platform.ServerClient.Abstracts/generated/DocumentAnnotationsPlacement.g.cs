using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAnnotationsPlacement(SDK.DocumentAnnotationsPlacement obj) : IDocumentAnnotationsPlacement
    {
        internal SDK.DocumentAnnotationsPlacement Obj { get; } = obj;

		public List<ISectionAnnotationsPlacement> Annotations
		{
			get => Obj.Annotations.Select(x => new SectionAnnotationsPlacement(x) as ISectionAnnotationsPlacement).ToList();
			set => Obj.Annotations = value.Select(x => ((SectionAnnotationsPlacement)x).Obj).ToList();
		}
    }
}
