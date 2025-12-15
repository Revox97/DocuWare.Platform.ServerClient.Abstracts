using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnValue(SDK.ColumnValue obj) : IColumnValue
    {
        internal SDK.ColumnValue Obj { get; } = obj;

        public ITaskFieldValue Value
        {
            get => new TaskFieldValue(Obj.Value);
            set => Obj.Value = ((TaskFieldValue)value).Obj;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
