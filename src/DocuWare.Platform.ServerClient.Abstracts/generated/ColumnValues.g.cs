using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnValues(SDK.ColumnValues obj) : IColumnValues
    {
        internal SDK.ColumnValues Obj { get; } = obj;

        public List<IColumnValue> ColumnValue
        {
            get => Obj.ColumnValue.Select(x => new ColumnValue(x) as IColumnValue).ToList();
            set => Obj.ColumnValue = value.Select(x => ((ColumnValue)x).Obj).ToList();
        }
    }
}
