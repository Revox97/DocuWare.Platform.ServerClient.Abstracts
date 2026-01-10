using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListFilter(DocuWare.Platform.ServerClient.SelectListFilter obj) : ISelectListFilter
    {
        internal DocuWare.Platform.ServerClient.SelectListFilter Obj { get; } = obj;

        public string ColumnName
        {
            get => Obj.ColumnName;
            set => Obj.ColumnName = value;
        }

        public int WorkflowFieldId
        {
            get => Obj.WorkflowFieldId;
            set => Obj.WorkflowFieldId = value;
        }
    }
}
