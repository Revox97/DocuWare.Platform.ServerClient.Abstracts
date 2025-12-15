using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HttpMethodList(SDK.HttpMethodList obj) : IHttpMethodList
    {
        internal SDK.HttpMethodList Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.HttpMethod> Method
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
