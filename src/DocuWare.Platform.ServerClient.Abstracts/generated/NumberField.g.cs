using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumberField(SDK.NumberField obj) : INumberField
    {
        internal SDK.NumberField Obj { get; } = obj;

		public bool ForceDecimalPlaces
		{
			get => Obj.ForceDecimalPlaces;
			set => Obj.ForceDecimalPlaces = value;
		}

		public int DecimalPlaces
		{
			get => Obj.DecimalPlaces;
			set => Obj.DecimalPlaces = value;
		}

		public double? MinValue
		{
			get => Obj.MinValue;
			set => Obj.MinValue = value;
		}

		public bool MinValueSpecified
		{
			get => Obj.MinValueSpecified;
			set => Obj.MinValueSpecified = value;
		}

		public double? MaxValue
		{
			get => Obj.MaxValue;
			set => Obj.MaxValue = value;
		}

		public bool MaxValueSpecified
		{
			get => Obj.MaxValueSpecified;
			set => Obj.MaxValueSpecified = value;
		}

		public PredefinedEntryType PredefinedEntry
		{
			get => new redefinedEntryType(Obj.PredefinedEntry);
			set => Obj.PredefinedEntry = ((redefinedEntryType)value).Obj;
		}

		public double? PredefinedCustomEntry
		{
			get => Obj.PredefinedCustomEntry;
			set => Obj.PredefinedCustomEntry = value;
		}

		public bool PredefinedCustomEntrySpecified
		{
			get => Obj.PredefinedCustomEntrySpecified;
			set => Obj.PredefinedCustomEntrySpecified = value;
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
