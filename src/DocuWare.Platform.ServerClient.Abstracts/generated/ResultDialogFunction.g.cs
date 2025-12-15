using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultDialogFunction(SDK.ResultDialogFunction obj) : IResultDialogFunction
    {
        internal SDK.ResultDialogFunction Obj { get; } = obj;

		public ResultDialogFunctionType Type
		{
			get => new esultDialogFunctionType(Obj.Type);
			set => Obj.Type = ((esultDialogFunctionType)value).Obj;
		}

		public bool InToolBar
		{
			get => Obj.InToolBar;
			set => Obj.InToolBar = value;
		}

		public bool AsButton
		{
			get => Obj.AsButton;
			set => Obj.AsButton = value;
		}
    }
}
