using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CreatedInfo(DocuWare.Platform.ServerClient.CreatedInfo obj) : ICreatedInfo
    {
        internal DocuWare.Platform.ServerClient.CreatedInfo Obj { get; } = obj;

        public string User
        {
            get => Obj.User;
            set => Obj.User = value;
        }

        public DateTime Time
        {
            get => Obj.Time;
            set => Obj.Time = value;
        }
    }
}
