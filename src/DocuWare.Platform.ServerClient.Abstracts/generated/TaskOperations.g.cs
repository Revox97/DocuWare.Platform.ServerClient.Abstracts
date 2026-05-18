using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskOperations(SDK.TaskOperations obj) : ITaskOperations
    {
        internal SDK.TaskOperations Obj { get; } = obj;

        public IBaseTaskOperations BaseTaskOperations
        {
            get => new BaseTaskOperations(Obj.BaseTaskOperations);
            set => Obj.BaseTaskOperations = ((BaseTaskOperations)value).Obj;
        }

        public IExtendedControllerOperations ExtendedControllerOperations
        {
            get => new ExtendedControllerOperations(Obj.ExtendedControllerOperations);
            set => Obj.ExtendedControllerOperations = ((ExtendedControllerOperations)value).Obj;
        }

        public IExtendedUserOperations ExtendedUserOperations
        {
            get => new ExtendedUserOperations(Obj.ExtendedUserOperations);
            set => Obj.ExtendedUserOperations = ((ExtendedUserOperations)value).Obj;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
