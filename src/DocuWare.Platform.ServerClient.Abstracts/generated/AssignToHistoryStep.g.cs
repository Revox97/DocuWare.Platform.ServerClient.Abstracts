using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AssignToHistoryStep(DocuWare.Platform.ServerClient.AssignToHistoryStep obj) : IAssignToHistoryStep
    {
        internal DocuWare.Platform.ServerClient.AssignToHistoryStep Obj { get; } = obj;

        public List<string> AssignedUsers
        {
            get => Obj.AssignedUsers;
            set => Obj.AssignedUsers = value;
        }
    }
}
