using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinCondition(DocuWare.Platform.ServerClient.TrashBinCondition obj) : ITrashBinCondition
    {
        internal DocuWare.Platform.ServerClient.TrashBinCondition Obj { get; } = obj;

        public List<string> Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public string DBName
        {
            get => Obj.DBName;
            set => Obj.DBName = value;
        }
    }
}
