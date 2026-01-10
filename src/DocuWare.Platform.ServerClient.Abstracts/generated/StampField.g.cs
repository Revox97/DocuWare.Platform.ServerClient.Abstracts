using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampField(DocuWare.Platform.ServerClient.StampField obj) : IStampField
    {
        internal DocuWare.Platform.ServerClient.StampField Obj { get; } = obj;

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
            get => (DWFieldType)Obj.DWType;
            set => Obj.DWType = (DocuWare.Platform.ServerClient.DWFieldType)value;
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
