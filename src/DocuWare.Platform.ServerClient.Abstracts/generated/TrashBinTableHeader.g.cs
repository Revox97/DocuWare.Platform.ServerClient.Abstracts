using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinTableHeader(SDK.TrashBinTableHeader obj) : ITrashBinTableHeader
    {
        internal SDK.TrashBinTableHeader Obj { get; } = obj;

		public string FieldName
		{
			get => Obj.FieldName;
			set => Obj.FieldName = value;
		}

		public string Type
		{
			get => Obj.Type;
			set => Obj.Type = value;
		}

		public string Label
		{
			get => Obj.Label;
			set => Obj.Label = value;
		}
    }
}
