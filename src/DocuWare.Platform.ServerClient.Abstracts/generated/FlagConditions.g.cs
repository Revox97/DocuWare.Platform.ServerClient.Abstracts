using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FlagConditions(DocuWare.Platform.ServerClient.FlagConditions obj) : IFlagConditions
    {
        internal DocuWare.Platform.ServerClient.FlagConditions Obj { get; } = obj;

        public bool IncludeCheckedOut
        {
            get => Obj.IncludeCheckedOut;
            set => Obj.IncludeCheckedOut = value;
        }

        public bool IncludeAppended
        {
            get => Obj.IncludeAppended;
            set => Obj.IncludeAppended = value;
        }
    }
}
