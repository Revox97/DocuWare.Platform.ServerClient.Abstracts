using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReassignmentData(SDK.ReassignmentData obj) : IReassignmentData
    {
        internal SDK.ReassignmentData Obj { get; } = obj;

		public List<IAssignedItem> ReassignmentList
		{
			get => Obj.ReassignmentList.Select(x => new AssignedItem(x) as IAssignedItem).ToList();
			set => Obj.ReassignmentList = value.Select(x => ((AssignedItem)x).Obj).ToList();
		}

		public string Subject
		{
			get => Obj.Subject;
			set => Obj.Subject = value;
		}

		public string Body
		{
			get => Obj.Body;
			set => Obj.Body = value;
		}

		public bool SendEmail
		{
			get => Obj.SendEmail;
			set => Obj.SendEmail = value;
		}
    }
}
