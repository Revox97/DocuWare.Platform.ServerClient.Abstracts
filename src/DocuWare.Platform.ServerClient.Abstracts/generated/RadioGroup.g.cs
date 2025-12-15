using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RadioGroup(SDK.RadioGroup obj) : IRadioGroup
    {
        internal SDK.RadioGroup Obj { get; } = obj;

		public List<IWebFormOption> Options
		{
			get => Obj.Options.Select(x => new WebFormOption(x) as IWebFormOption).ToList();
			set => Obj.Options = value.Select(x => ((WebFormOption)x).Obj).ToList();
		}

		public OrientationType Orientation
		{
			get => new rientationType(Obj.Orientation);
			set => Obj.Orientation = ((rientationType)value).Obj;
		}

		public int NumberOfColumns
		{
			get => Obj.NumberOfColumns;
			set => Obj.NumberOfColumns = value;
		}

		public ColumnWidthType ColumnWidth
		{
			get => new olumnWidthType(Obj.ColumnWidth);
			set => Obj.ColumnWidth = ((olumnWidthType)value).Obj;
		}

		public string SortOrder
		{
			get => Obj.SortOrder;
			set => Obj.SortOrder = value;
		}

		public List<List<IWebFormOption>> OptionsRows
		{
			get => Obj.OptionsRows;
			set => Obj.OptionsRows = value;
		}

		public string PredefinedValue
		{
			get => Obj.PredefinedValue;
			set => Obj.PredefinedValue = value;
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
