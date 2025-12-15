using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CreatedInfo(SDK.CreatedInfo obj) : ICreatedInfo
    {
        internal SDK.CreatedInfo Obj { get; } = obj;

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
