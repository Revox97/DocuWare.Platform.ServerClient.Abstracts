using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableNumberField(SDK.TaskTableNumberField obj) : ITaskTableNumberField
    {
        internal SDK.TaskTableNumberField Obj { get; } = obj;

		public bool PrefillWithBalance
		{
			get => Obj.PrefillWithBalance;
			set => Obj.PrefillWithBalance = value;
		}

		public string BalanceField
		{
			get => Obj.BalanceField;
			set => Obj.BalanceField = value;
		}

		public int Precision
		{
			get => Obj.Precision;
			set => Obj.Precision = value;
		}

		public bool CalculateSum
		{
			get => Obj.CalculateSum;
			set => Obj.CalculateSum = value;
		}

		public IWFFormFieldValue PrefillValue
		{
			get => new WFFormFieldValue(Obj.PrefillValue);
			set => Obj.PrefillValue = ((WFFormFieldValue)value).Obj;
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
			get => new ormTypeEnum(Obj.FormFieldType);
			set => Obj.FormFieldType = ((ormTypeEnum)value).Obj;
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
