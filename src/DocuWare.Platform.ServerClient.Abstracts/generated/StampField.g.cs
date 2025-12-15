using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampField(SDK.StampField obj) : IStampField
    {
        internal SDK.StampField Obj { get; } = obj;

		public IDocumentIndexFieldValue Value
		{
			get => new DocumentIndexFieldValue(Obj.Value);
			set => Obj.Value = ((DocumentIndexFieldValue)value).Obj;
		}

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public DWFieldType DWType
		{
			get => new WFieldType(Obj.DWType);
			set => Obj.DWType = ((WFieldType)value).Obj;
		}

		public int Length
		{
			get => Obj.Length;
			set => Obj.Length = value;
		}

		public bool HasFixedEntry
		{
			get => Obj.HasFixedEntry;
			set => Obj.HasFixedEntry = value;
		}
    }
}
