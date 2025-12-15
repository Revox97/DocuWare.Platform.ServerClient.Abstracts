using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControl(SDK.WebFormControl obj) : IWebFormControl
    {
        internal SDK.WebFormControl Obj { get; } = obj;

		public string ID
		{
			get => Obj.ID;
			set => Obj.ID = value;
		}

		public string Label
		{
			get => Obj.Label;
			set => Obj.Label = value;
		}

		public IPosition Position
		{
			get => new Position(Obj.Position);
			set => Obj.Position = ((Position)value).Obj;
		}

		public string BehaviorID
		{
			get => Obj.BehaviorID;
			set => Obj.BehaviorID = value;
		}
    }
}
