using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListExpression(DocuWare.Platform.ServerClient.SelectListExpression obj) : ISelectListExpression
    {
        internal DocuWare.Platform.ServerClient.SelectListExpression Obj { get; } = obj;

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

        public bool ExcludeExternal
        {
            get => Obj.ExcludeExternal;
            set => Obj.ExcludeExternal = value;
        }

        public bool Typed
        {
            get => Obj.Typed;
            set => Obj.Typed = value;
        }
    }
}
