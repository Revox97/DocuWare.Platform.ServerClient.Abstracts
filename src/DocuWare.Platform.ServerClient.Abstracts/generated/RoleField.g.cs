using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RoleField(DocuWare.Platform.ServerClient.RoleField obj) : IRoleField
    {
        internal DocuWare.Platform.ServerClient.RoleField Obj { get; } = obj;

        public bool IsMultiselect
        {
            get => Obj.IsMultiselect;
            set => Obj.IsMultiselect = value;
        }

        public List<ISelectListFilter> SelectListFilters
        {
            get => Obj.SelectListFilters.Select(x => new SelectListFilter(x) as ISelectListFilter).ToList();
            set => Obj.SelectListFilters = value.Select(x => ((SelectListFilter)x).Obj).ToList();
        }

        public bool Mandatory
        {
            get => Obj.Mandatory;
            set => Obj.Mandatory = value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public bool HasSelectList
        {
            get => Obj.HasSelectList;
            set => Obj.HasSelectList = value;
        }

        public bool IsReadOnly
        {
            get => Obj.IsReadOnly;
            set => Obj.IsReadOnly = value;
        }

        public bool IsSelectListOnly
        {
            get => Obj.IsSelectListOnly;
            set => Obj.IsSelectListOnly = value;
        }

        public string SelectListGuid
        {
            get => Obj.SelectListGuid;
            set => Obj.SelectListGuid = value;
        }

        public string SelectListColumn
        {
            get => Obj.SelectListColumn;
            set => Obj.SelectListColumn = value;
        }

        public bool IsHiddenInStamp
        {
            get => Obj.IsHiddenInStamp;
            set => Obj.IsHiddenInStamp = value;
        }

        public FormTypeEnum FormFieldType
        {
            get => (FormTypeEnum)Obj.FormFieldType;
            set => Obj.FormFieldType = (DocuWare.Platform.ServerClient.FormTypeEnum)value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
