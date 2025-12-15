using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableColumn(SDK.TaskTableColumn obj) : ITaskTableColumn
    {
        internal SDK.TaskTableColumn Obj { get; } = obj;

		public ITaskTableColumnBase BaseData
		{
			get => new TaskTableColumnBase(Obj.BaseData);
			set => Obj.BaseData = ((TaskTableColumnBase)value).Obj;
		}

		public string FieldName
		{
			get => Obj.FieldName;
			set => Obj.FieldName = value;
		}

		public bool IsHidden
		{
			get => Obj.IsHidden;
			set => Obj.IsHidden = value;
		}
    }
}
