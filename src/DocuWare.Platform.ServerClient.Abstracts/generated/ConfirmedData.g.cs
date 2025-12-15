using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfirmedData(SDK.ConfirmedData obj) : IConfirmedData
    {
        internal SDK.ConfirmedData Obj { get; } = obj;

		public List<IConfirmedField> ConfirmedFields
		{
			get => Obj.ConfirmedFields.Select(x => new ConfirmedField(x) as IConfirmedField).ToList();
			set => Obj.ConfirmedFields = value.Select(x => ((ConfirmedField)x).Obj).ToList();
		}
    }
}
