using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckOutActionParameters(DocuWare.Platform.ServerClient.CheckOutActionParameters obj) : ICheckOutActionParameters
    {
        internal DocuWare.Platform.ServerClient.CheckOutActionParameters Obj { get; } = obj;

        public string FileCabinetId
        {
            get => Obj.FileCabinetId;
            set => Obj.FileCabinetId = value;
        }
    }
}
