using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntegerList(DocuWare.Platform.ServerClient.IntegerList obj) : IIntegerList
    {
        internal DocuWare.Platform.ServerClient.IntegerList Obj { get; } = obj;

        public List<int> Int
        {
            get => Obj.Int;
            set => Obj.Int = value;
        }
    }
}
