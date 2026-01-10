using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetSelectListExpression(DocuWare.Platform.ServerClient.FileCabinetSelectListExpression obj) : IFileCabinetSelectListExpression
    {
        internal DocuWare.Platform.ServerClient.FileCabinetSelectListExpression Obj { get; } = obj;

        public string ValuePrefix
        {
            get => Obj.ValuePrefix;
            set => Obj.ValuePrefix = value;
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

        public int Limit
        {
            get => Obj.Limit;
            set => Obj.Limit = value;
        }

        public SortDirection SortDirection
        {
            get => (SortDirection)Obj.SortDirection;
            set => Obj.SortDirection = (DocuWare.Platform.ServerClient.SortDirection)value;
        }

        public bool Typed
        {
            get => Obj.Typed;
            set => Obj.Typed = value;
        }
    }
}
