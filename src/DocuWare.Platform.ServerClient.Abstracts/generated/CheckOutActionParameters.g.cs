using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckOutActionParameters(SDK.CheckOutActionParameters obj) : ICheckOutActionParameters
    {
        internal SDK.CheckOutActionParameters Obj { get; } = obj;

		public string FileCabinetId
		{
			get => Obj.FileCabinetId;
			set => Obj.FileCabinetId = value;
		}
    }
}
