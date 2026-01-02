using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinSelectListExpression(SDK.TrashBinSelectListExpression obj) : ITrashBinSelectListExpression
    {
        internal SDK.TrashBinSelectListExpression Obj { get; } = obj;

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

        public DocuWare.Platform.ServerClient.SortDirection SortDirection
        {
            get => Obj.SortDirection;
            set => Obj.SortDirection = value;
        }
    }
}
