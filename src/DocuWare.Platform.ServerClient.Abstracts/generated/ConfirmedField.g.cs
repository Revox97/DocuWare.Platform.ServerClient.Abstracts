using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfirmedField(SDK.ConfirmedField obj) : IConfirmedField
    {
        internal SDK.ConfirmedField Obj { get; } = obj;

		public IWFFormFieldValue Value
		{
			get => new WFFormFieldValue(Obj.Value);
			set => Obj.Value = ((WFFormFieldValue)value).Obj;
		}

		public int Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}

		public bool IdSpecified
		{
			get => Obj.IdSpecified;
			set => Obj.IdSpecified = value;
		}
    }
}
