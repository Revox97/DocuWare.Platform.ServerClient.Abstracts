using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Notification(SDK.Notification obj) : INotification
    {
        internal SDK.Notification Obj { get; } = obj;

        public DateTime? TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }

        public bool IsActive
        {
            get => Obj.IsActive;
            set => Obj.IsActive = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
