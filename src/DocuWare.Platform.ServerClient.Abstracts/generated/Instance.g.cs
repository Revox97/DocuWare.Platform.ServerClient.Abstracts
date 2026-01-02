using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Instance(DocuWare.Platform.ServerClient.Instance obj) : IInstance
    {
        internal DocuWare.Platform.ServerClient.Instance Obj { get; } = obj;

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
