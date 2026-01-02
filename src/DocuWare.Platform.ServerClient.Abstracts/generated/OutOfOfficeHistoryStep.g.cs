using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OutOfOfficeHistoryStep(DocuWare.Platform.ServerClient.OutOfOfficeHistoryStep obj) : IOutOfOfficeHistoryStep
    {
        internal DocuWare.Platform.ServerClient.OutOfOfficeHistoryStep Obj { get; } = obj;

        public string NewUser
        {
            get => Obj.NewUser;
            set => Obj.NewUser = value;
        }

        public string OutOfOfficeUser
        {
            get => Obj.OutOfOfficeUser;
            set => Obj.OutOfOfficeUser = value;
        }
    }
}
