using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HttpMethodList(DocuWare.Platform.ServerClient.HttpMethodList obj) : IHttpMethodList
    {
        internal DocuWare.Platform.ServerClient.HttpMethodList Obj { get; } = obj;

        public List<HttpMethod> Method
        {
            get => Obj.Method;
            set => Obj.Method = value;
        }

        public bool IsComplete
        {
            get => Obj.IsComplete;
            set => Obj.IsComplete = value;
        }
    }
}
