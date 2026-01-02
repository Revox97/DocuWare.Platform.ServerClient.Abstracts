using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogField(SDK.DialogField obj) : IDialogField
    {
        internal SDK.DialogField Obj { get; } = obj;

        public List<IDialogFieldBase> DialogTableFieldColumns
        {
            get => Obj.DialogTableFieldColumns.Select(x => new DialogFieldBase(x) as IDialogFieldBase).ToList();
            set => Obj.DialogTableFieldColumns = value.Select(x => ((DialogFieldBase)x).Obj).ToList();
        }

        public bool UsedAsDocumentName
        {
            get => Obj.UsedAsDocumentName;
            set => Obj.UsedAsDocumentName = value;
        }

        public bool IsHierarchy
        {
            get => Obj.IsHierarchy;
            set => Obj.IsHierarchy = value;
        }

        public string SampleEditText
        {
            get => Obj.SampleEditText;
            set => Obj.SampleEditText = value;
        }

        public List<IDocumentIndexFieldValue> PrefillValue
        {
            get => Obj.PrefillValue.Select(x => new DocumentIndexFieldValue(x) as IDocumentIndexFieldValue).ToList();
            set => Obj.PrefillValue = value.Select(x => ((DocumentIndexFieldValue)x).Obj).ToList();
        }

        public List<DocuWare.Platform.ServerClient.DynamicValueType> DynamicPrefillValue
        {
            get => Obj.DynamicPrefillValue;
            set => Obj.DynamicPrefillValue = value;
        }

        public List<ISelectListInfo> SelectListInfos
        {
            get => Obj.SelectListInfos.Select(x => new SelectListInfo(x) as ISelectListInfo).ToList();
            set => Obj.SelectListInfos = value.Select(x => ((SelectListInfo)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string DBFieldName
        {
            get => Obj.DBFieldName;
            set => Obj.DBFieldName = value;
        }

        public string DlgLabel
        {
            get => Obj.DlgLabel;
            set => Obj.DlgLabel = value;
        }

        public DocuWare.Platform.ServerClient.DWFieldType DWFieldType
        {
            get => Obj.DWFieldType;
            set => Obj.DWFieldType = value;
        }

        public bool Locked
        {
            get => Obj.Locked;
            set => Obj.Locked = value;
        }

        public bool ReadOnly
        {
            get => Obj.ReadOnly;
            set => Obj.ReadOnly = value;
        }

        public bool NotEmpty
        {
            get => Obj.NotEmpty;
            set => Obj.NotEmpty = value;
        }

        public bool Visible
        {
            get => Obj.Visible;
            set => Obj.Visible = value;
        }

        public int Length
        {
            get => Obj.Length;
            set => Obj.Length = value;
        }

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }

        public bool AllowExtendedSearch
        {
            get => Obj.AllowExtendedSearch;
            set => Obj.AllowExtendedSearch = value;
        }

        public bool AllowFiltering
        {
            get => Obj.AllowFiltering;
            set => Obj.AllowFiltering = value;
        }

        public bool SelectListOnly
        {
            get => Obj.SelectListOnly;
            set => Obj.SelectListOnly = value;
        }

        public DocuWare.Platform.ServerClient.SelectListType SelectListType
        {
            get => Obj.SelectListType;
            set => Obj.SelectListType = value;
        }

        public bool AssignedInternalSelectList
        {
            get => Obj.AssignedInternalSelectList;
            set => Obj.AssignedInternalSelectList = value;
        }

        public string SequenceId
        {
            get => Obj.SequenceId;
            set => Obj.SequenceId = value;
        }

        public bool SelectListsAssigned
        {
            get => Obj.SelectListsAssigned;
            set => Obj.SelectListsAssigned = value;
        }

        public bool CalculateSum
        {
            get => Obj.CalculateSum;
            set => Obj.CalculateSum = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
