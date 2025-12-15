using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTextField(SDK.TaskTextField obj) : ITaskTextField
    {
        internal SDK.TaskTextField Obj { get; } = obj;

		public IFieldMask FieldMask
		{
			get => new FieldMask(Obj.FieldMask);
			set => Obj.FieldMask = ((FieldMask)value).Obj;
		}

		public int Length
		{
			get => Obj.Length;
			set => Obj.Length = value;
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
