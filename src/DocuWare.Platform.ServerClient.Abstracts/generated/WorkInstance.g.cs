using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkInstance(SDK.WorkInstance obj) : IWorkInstance
    {
        internal SDK.WorkInstance Obj { get; } = obj;

        public string ID
        {
            get => Obj.ID;
            set => Obj.ID = value;
        }
    }
}
