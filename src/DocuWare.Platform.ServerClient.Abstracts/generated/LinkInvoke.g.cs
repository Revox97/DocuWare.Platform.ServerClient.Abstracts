using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkInvoke(SDK.LinkInvoke obj) : ILinkInvoke
    {
        internal SDK.LinkInvoke Obj { get; } = obj;

		public IContentTypeList Accepts
		{
			get => new ContentTypeList(Obj.Accepts);
			set => Obj.Accepts = ((ContentTypeList)value).Obj;
		}

		public IContentTypeList Produces
		{
			get => new ContentTypeList(Obj.Produces);
			set => Obj.Produces = ((ContentTypeList)value).Obj;
		}

		public HttpMethod Verb
		{
			get => new ttpMethod(Obj.Verb);
			set => Obj.Verb = ((ttpMethod)value).Obj;
		}
    }
}
