using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskOperations(DocuWare.Platform.ServerClient.TaskOperations obj) : ITaskOperations
    {
        internal DocuWare.Platform.ServerClient.TaskOperations Obj { get; } = obj;

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
