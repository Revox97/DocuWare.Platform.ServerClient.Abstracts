using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableColumnsDefinition(SDK.TableColumnsDefinition obj) : ITableColumnsDefinition
    {
        internal SDK.TableColumnsDefinition Obj { get; } = obj;

		public ITableColumnOptions ColumnOptions
		{
			get => new TableColumnOptions(Obj.ColumnOptions);
			set => Obj.ColumnOptions = ((TableColumnOptions)value).Obj;
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

		public TableColumnValueTypeEnum ColumnValueType
		{
			get => new ableColumnValueTypeEnum(Obj.ColumnValueType);
			set => Obj.ColumnValueType = ((ableColumnValueTypeEnum)value).Obj;
		}

		public bool Mandatory
		{
			get => Obj.Mandatory;
			set => Obj.Mandatory = value;
		}
    }
}
