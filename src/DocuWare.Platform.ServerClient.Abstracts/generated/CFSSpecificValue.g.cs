using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CFSSpecificValue(DocuWare.Platform.ServerClient.CFSSpecificValue obj) : ICFSSpecificValue
    {
        internal DocuWare.Platform.ServerClient.CFSSpecificValue Obj { get; } = obj;

        public string ValueName
        {
            get => Obj.ValueName;
            set => Obj.ValueName = value;
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
