using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkInstance(DocuWare.Platform.ServerClient.WebClient.WorkInstance obj) : IWorkInstance
    {
        internal DocuWare.Platform.ServerClient.WebClient.WorkInstance Obj { get; } = obj;

        public string ID
        {
            get => Obj.ID;
            set => Obj.ID = value;
        }
    }
}
