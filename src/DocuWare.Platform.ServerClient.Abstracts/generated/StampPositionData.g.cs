using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampPositionData(SDK.StampPositionData obj) : IStampPositionData
    {
        internal SDK.StampPositionData Obj { get; } = obj;

		public string SectionId
		{
			get => Obj.SectionId;
			set => Obj.SectionId = value;
		}

		public int Page
		{
			get => Obj.Page;
			set => Obj.Page = value;
		}

		public List<IConfirmedField> ConfirmedFields
		{
			get => Obj.ConfirmedFields.Select(x => new ConfirmedField(x) as IConfirmedField).ToList();
			set => Obj.ConfirmedFields = value.Select(x => ((ConfirmedField)x).Obj).ToList();
		}
    }
}
