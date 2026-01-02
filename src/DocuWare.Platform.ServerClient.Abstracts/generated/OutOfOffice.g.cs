using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OutOfOffice(SDK.OutOfOffice obj) : IOutOfOffice
    {
        internal SDK.OutOfOffice Obj { get; } = obj;

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
