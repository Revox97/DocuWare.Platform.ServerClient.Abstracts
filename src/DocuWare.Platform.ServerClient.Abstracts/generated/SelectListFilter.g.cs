using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListFilter(SDK.SelectListFilter obj) : ISelectListFilter
    {
        internal SDK.SelectListFilter Obj { get; } = obj;

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
