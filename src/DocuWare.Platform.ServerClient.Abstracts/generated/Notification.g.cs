using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Notification(DocuWare.Platform.ServerClient.Notification obj) : INotification
    {
        internal DocuWare.Platform.ServerClient.Notification Obj { get; } = obj;

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
