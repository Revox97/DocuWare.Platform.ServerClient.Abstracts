using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OutOfOffice(DocuWare.Platform.ServerClient.OutOfOffice obj) : IOutOfOffice
    {
        internal DocuWare.Platform.ServerClient.OutOfOffice Obj { get; } = obj;

        public bool IsOutOfOffice
        {
            get => Obj.IsOutOfOffice;
            set => Obj.IsOutOfOffice = value;
        }

        public DateTime StartDateTime
        {
            get => Obj.StartDateTime;
            set => Obj.StartDateTime = value;
        }

        public DateTime EndDateTime
        {
            get => Obj.EndDateTime;
            set => Obj.EndDateTime = value;
        }
    }
}
