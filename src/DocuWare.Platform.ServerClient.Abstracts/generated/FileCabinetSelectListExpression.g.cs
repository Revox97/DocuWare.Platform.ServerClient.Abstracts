using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetSelectListExpression(SDK.FileCabinetSelectListExpression obj) : IFileCabinetSelectListExpression
    {
        internal SDK.FileCabinetSelectListExpression Obj { get; } = obj;

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

        public int Limit
        {
            get => Obj.Limit;
            set => Obj.Limit = value;
        }

        public DocuWare.Platform.ServerClient.SortDirection SortDirection
        {
            get => Obj.SortDirection;
            set => Obj.SortDirection = value;
        }

        public bool Typed
        {
            get => Obj.Typed;
            set => Obj.Typed = value;
        }
    }
}
