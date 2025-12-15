using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetHistoryField(SDK.FileCabinetHistoryField obj) : IFileCabinetHistoryField
    {
        internal SDK.FileCabinetHistoryField Obj { get; } = obj;

		public string FileCabinetName
		{
			get => Obj.FileCabinetName;
			set => Obj.FileCabinetName = value;
		}

		public string DocId
		{
			get => Obj.DocId;
			set => Obj.DocId = value;
		}

		public IWFFormFieldValue Value
		{
			get => new WFFormFieldValue(Obj.Value);
			set => Obj.Value = ((WFFormFieldValue)value).Obj;
		}

		public IHistoryFieldOptions Options
		{
			get => new HistoryFieldOptions(Obj.Options);
			set => Obj.Options = ((HistoryFieldOptions)value).Obj;
		}

		public AssignmentType AssignmentType
		{
			get => new ssignmentType(Obj.AssignmentType);
			set => Obj.AssignmentType = ((ssignmentType)value).Obj;
		}

		public string Label
		{
			get => Obj.Label;
			set => Obj.Label = value;
		}

		public HistoryFormTypeEnum Type
		{
			get => new istoryFormTypeEnum(Obj.Type);
			set => Obj.Type = ((istoryFormTypeEnum)value).Obj;
		}
    }
}
