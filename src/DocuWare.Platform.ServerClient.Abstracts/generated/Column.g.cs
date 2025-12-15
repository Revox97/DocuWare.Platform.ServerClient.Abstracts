using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Column(SDK.Column obj) : IColumn
    {
        internal SDK.Column Obj { get; } = obj;

		public IColumnOptions ColumnOptions
		{
			get => new ColumnOptions(Obj.ColumnOptions);
			set => Obj.ColumnOptions = ((ColumnOptions)value).Obj;
		}

		public string Label
		{
			get => Obj.Label;
			set => Obj.Label = value;
		}

		public string Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}

		public ColumnValueTypeEnum ColumnValueType
		{
			get => new olumnValueTypeEnum(Obj.ColumnValueType);
			set => Obj.ColumnValueType = ((olumnValueTypeEnum)value).Obj;
		}

		public ColumnTypeEnum ColumnType
		{
			get => new olumnTypeEnum(Obj.ColumnType);
			set => Obj.ColumnType = ((olumnTypeEnum)value).Obj;
		}
    }
}
