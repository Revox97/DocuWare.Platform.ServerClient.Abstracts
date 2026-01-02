using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDialogQuery(DocuWare.Platform.ServerClient.RequestDialogQuery obj) : IRequestDialogQuery
    {
        internal DocuWare.Platform.ServerClient.RequestDialogQuery Obj { get; } = obj;

        public List<DialogTypes> DialogTypes
        {
            get => Obj.DialogTypes;
            set => Obj.DialogTypes = value;
        }
    }
}
