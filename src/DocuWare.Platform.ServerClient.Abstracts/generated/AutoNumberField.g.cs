using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AutoNumberField(SDK.AutoNumberField obj) : IAutoNumberField
    {
        internal SDK.AutoNumberField Obj { get; } = obj;

		public int NumberGroupID
		{
			get => Obj.NumberGroupID;
			set => Obj.NumberGroupID = value;
		}

		public string NumberGroupGuid
		{
			get => Obj.NumberGroupGuid;
			set => Obj.NumberGroupGuid = value;
		}

		public string SourceFileCabinet
		{
			get => Obj.SourceFileCabinet;
			set => Obj.SourceFileCabinet = value;
		}

		public int FontSize
		{
			get => Obj.FontSize;
			set => Obj.FontSize = value;
		}

		public string FontColor
		{
			get => Obj.FontColor;
			set => Obj.FontColor = value;
		}

		public string Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}

		public string Type
		{
			get => Obj.Type;
			set => Obj.Type = value;
		}

		public bool Hidden
		{
			get => Obj.Hidden;
			set => Obj.Hidden = value;
		}

		public bool Readonly
		{
			get => Obj.Readonly;
			set => Obj.Readonly = value;
		}

		public bool Required
		{
			get => Obj.Required;
			set => Obj.Required = value;
		}

		public string Hint
		{
			get => Obj.Hint;
			set => Obj.Hint = value;
		}

		public string ValidationID
		{
			get => Obj.ValidationID;
			set => Obj.ValidationID = value;
		}

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
