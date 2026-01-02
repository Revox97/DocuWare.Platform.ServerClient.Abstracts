using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogExpressionCondition(DocuWare.Platform.ServerClient.DialogExpressionCondition obj) : IDialogExpressionCondition
    {
        internal DocuWare.Platform.ServerClient.DialogExpressionCondition Obj { get; } = obj;

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
