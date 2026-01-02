using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampField(SDK.StampField obj) : IStampField
    {
        internal SDK.StampField Obj { get; } = obj;

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
