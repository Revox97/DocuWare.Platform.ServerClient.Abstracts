using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignToHistoryStep(SDK.AssignToHistoryStep obj) : IAssignToHistoryStep
    {
        internal SDK.AssignToHistoryStep Obj { get; } = obj;

        public List<string> AssignedUsers
        {
            get => Obj.AssignedUsers;
            set => Obj.AssignedUsers = value;
        }
    }
}
