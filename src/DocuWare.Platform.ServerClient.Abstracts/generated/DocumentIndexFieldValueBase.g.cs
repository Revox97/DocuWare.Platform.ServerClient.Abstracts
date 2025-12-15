using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldValueBase(SDK.DocumentIndexFieldValueBase obj) : IDocumentIndexFieldValueBase
    {
        internal SDK.DocumentIndexFieldValueBase Obj { get; } = obj;

		public Object Item
		{
			get => Obj.Item;
			set => Obj.Item = value;
		}

		public ItemChoiceType ItemElementName
		{
			get => new temChoiceType(Obj.ItemElementName);
			set => Obj.ItemElementName = ((temChoiceType)value).Obj;
		}
    }
}
