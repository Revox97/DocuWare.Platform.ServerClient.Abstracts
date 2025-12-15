using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HistoryStepInfoBase(SDK.HistoryStepInfoBase obj) : IHistoryStepInfoBase
    {
        internal SDK.HistoryStepInfoBase Obj { get; } = obj;

		public Object Item
		{
			get => Obj.Item;
			set => Obj.Item = value;
		}
    }
}
