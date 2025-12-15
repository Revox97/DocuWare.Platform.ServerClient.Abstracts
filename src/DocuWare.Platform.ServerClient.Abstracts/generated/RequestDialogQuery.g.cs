using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDialogQuery(SDK.RequestDialogQuery obj) : IRequestDialogQuery
    {
        internal SDK.RequestDialogQuery Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.DialogTypes> DialogTypes
        {
            get => Obj.DialogTypes;
            set => Obj.DialogTypes = value;
        }
    }
}
