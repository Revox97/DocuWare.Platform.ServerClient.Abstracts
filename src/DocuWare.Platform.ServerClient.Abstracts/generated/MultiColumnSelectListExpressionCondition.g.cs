using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColumnSelectListExpressionCondition(SDK.MultiColumnSelectListExpressionCondition obj) : IMultiColumnSelectListExpressionCondition
    {
        internal SDK.MultiColumnSelectListExpressionCondition Obj { get; } = obj;

		public string Type
		{
			get => Obj.Type;
			set => Obj.Type = value;
		}

		public List<string> Value
		{
			get => Obj.Value;
			set => Obj.Value = value;
		}

		public string DBName
		{
			get => Obj.DBName;
			set => Obj.DBName = value;
		}

		public string ColumnName
		{
			get => Obj.ColumnName;
			set => Obj.ColumnName = value;
		}
    }
}
