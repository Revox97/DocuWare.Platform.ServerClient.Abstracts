using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HttpMethodList(SDK.HttpMethodList obj) : IHttpMethodList
    {
        internal SDK.HttpMethodList Obj { get; } = obj;

		public List<HttpMethod> Method
		{
			get => Obj.Method.Select(x => new ttpMethod(x) as HttpMethod).ToList();
			set => Obj.Method = value.Select(x => ((ttpMethod)x).Obj).ToList();
		}

		public bool IsComplete
		{
			get => Obj.IsComplete;
			set => Obj.IsComplete = value;
		}
    }
}
