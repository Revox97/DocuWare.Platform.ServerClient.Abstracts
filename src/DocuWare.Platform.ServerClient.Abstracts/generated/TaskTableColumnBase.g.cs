using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableColumnBase(SDK.TaskTableColumnBase obj) : ITaskTableColumnBase
    {
        internal SDK.TaskTableColumnBase Obj { get; } = obj;

		public ICommonFormField Item
		{
			get => new CommonFormField(Obj.Item);
			set => Obj.Item = ((CommonFormField)value).Obj;
		}
    }
}
