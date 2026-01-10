using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckGroup(DocuWare.Platform.ServerClient.CheckGroup obj) : ICheckGroup
    {
        internal DocuWare.Platform.ServerClient.CheckGroup Obj { get; } = obj;

        public List<IWebFormOption> Options
        {
            get => Obj.Options.Select(x => new WebFormOption(x) as IWebFormOption).ToList();
            set => Obj.Options = value.Select(x => ((WebFormOption)x).Obj).ToList();
        }

        public OrientationType Orientation
        {
            get => (OrientationType)Obj.Orientation;
            set => Obj.Orientation = (DocuWare.Platform.ServerClient.OrientationType)value;
        }

        public int NumberOfColumns
        {
            get => Obj.NumberOfColumns;
            set => Obj.NumberOfColumns = value;
        }

        public ColumnWidthType ColumnWidth
        {
            get => (ColumnWidthType)Obj.ColumnWidth;
            set => Obj.ColumnWidth = (DocuWare.Platform.ServerClient.ColumnWidthType)value;
        }

        public string SortOrder
        {
            get => Obj.SortOrder;
            set => Obj.SortOrder = value;
        }

        public List<List<IWebFormOption>> OptionsRows
        {
            get
            {
                List<List<IWebFormOption>> result = new();

                foreach (var outer in Obj.OptionsRows)
                    result.Add(new(from inner in outer select new WebFormOption(inner)));

                return result;
            }
            set
            {
                List<List<SDK.WebFormOption>> result = new();

                foreach (var outer in value)
                    result.Add(new(from inner in outer select ((WebFormOption)inner).Obj));

                Obj.OptionsRows = result;
            }
        }

        public List<string> PredefinedValues
        {
            get => Obj.PredefinedValues;
            set => Obj.PredefinedValues = value;
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
