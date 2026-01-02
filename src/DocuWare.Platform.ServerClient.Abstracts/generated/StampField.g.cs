using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampField(DocuWare.Platform.ServerClient.StampField obj) : IStampField
    {
        internal DocuWare.Platform.ServerClient.StampField Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public DocuWare.Platform.ServerClient.DWFieldType DWType
        {
            get => Obj.DWType;
            set => Obj.DWType = value;
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
