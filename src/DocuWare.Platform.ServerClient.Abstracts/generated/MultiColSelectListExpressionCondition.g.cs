using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListExpressionCondition(DocuWare.Platform.ServerClient.MultiColSelectListExpressionCondition obj) : IMultiColSelectListExpressionCondition
    {
        internal DocuWare.Platform.ServerClient.MultiColSelectListExpressionCondition Obj { get; } = obj;

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public string ColumnName
        {
            get => Obj.ColumnName;
            set => Obj.ColumnName = value;
        }

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
