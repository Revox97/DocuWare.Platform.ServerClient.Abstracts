using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinSelectListExpression(DocuWare.Platform.ServerClient.TrashBinSelectListExpression obj) : ITrashBinSelectListExpression
    {
        internal DocuWare.Platform.ServerClient.TrashBinSelectListExpression Obj { get; } = obj;

        public string ValuePrefix
        {
            get => Obj.ValuePrefix;
            set => Obj.ValuePrefix = value;
        }

        public ITrashBinExpression Expression
        {
            get => new TrashBinExpression(Obj.Expression);
            set => Obj.Expression = ((TrashBinExpression)value).Obj;
        }

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }

        public int Start
        {
            get => Obj.Start;
            set => Obj.Start = value;
        }

        public SortDirection SortDirection
        {
            get => (SortDirection)Obj.SortDirection;
            set => Obj.SortDirection = (DocuWare.Platform.ServerClient.SortDirection)value;
        }
    }
}
