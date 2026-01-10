using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateField(DocuWare.Platform.ServerClient.DateField obj) : IDateField
    {
        internal DocuWare.Platform.ServerClient.DateField Obj { get; } = obj;

        public string LocalValue
        {
            get => Obj.LocalValue;
            set => Obj.LocalValue = value;
        }

        public PredefinedEntryType PredefinedEntry
        {
            get => (PredefinedEntryType)Obj.PredefinedEntry;
            set => Obj.PredefinedEntry = (DocuWare.Platform.ServerClient.PredefinedEntryType)value;
        }

        public string PredefinedCustomEntry
        {
            get => Obj.PredefinedCustomEntry;
            set => Obj.PredefinedCustomEntry = value;
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
