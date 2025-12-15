using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateTimeConstant(SDK.DateTimeConstant obj) : IDateTimeConstant
    {
        internal SDK.DateTimeConstant Obj { get; } = obj;

		public DateTime? Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}
    }
}
