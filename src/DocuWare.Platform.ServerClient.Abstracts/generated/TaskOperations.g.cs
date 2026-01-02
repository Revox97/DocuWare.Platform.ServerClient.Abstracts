using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskOperations(DocuWare.Platform.ServerClient.TaskOperations obj) : ITaskOperations
    {
        internal DocuWare.Platform.ServerClient.TaskOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
