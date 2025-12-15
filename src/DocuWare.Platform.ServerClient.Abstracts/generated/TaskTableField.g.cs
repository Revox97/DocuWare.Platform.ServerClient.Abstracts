using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableField(SDK.TaskTableField obj) : ITaskTableField
    {
        internal SDK.TaskTableField Obj { get; } = obj;

		public List<ITaskTableColumn> Columns
		{
			get => Obj.Columns.Select(x => new TaskTableColumn(x) as ITaskTableColumn).ToList();
			set => Obj.Columns = value.Select(x => ((TaskTableColumn)x).Obj).ToList();
		}

		public ITaskTableFieldInitialValues InitialValues
		{
			get => new TaskTableFieldInitialValues(Obj.InitialValues);
			set => Obj.InitialValues = ((TaskTableFieldInitialValues)value).Obj;
		}

		public string FieldName
		{
			get => Obj.FieldName;
			set => Obj.FieldName = value;
		}

		public bool Mandatory
		{
			get => Obj.Mandatory;
			set => Obj.Mandatory = value;
		}

		public bool IsReadOnly
		{
			get => Obj.IsReadOnly;
			set => Obj.IsReadOnly = value;
		}

		public FormTypeEnum FormFieldType
		{
			get => new ormTypeEnum(Obj.FormFieldType);
			set => Obj.FormFieldType = ((ormTypeEnum)value).Obj;
		}

		public string Label
		{
			get => Obj.Label;
			set => Obj.Label = value;
		}

		public int Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}
    }
}
