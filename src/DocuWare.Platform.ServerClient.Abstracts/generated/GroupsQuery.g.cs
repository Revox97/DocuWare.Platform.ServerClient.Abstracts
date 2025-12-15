using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GroupsQuery(SDK.GroupsQuery obj) : IGroupsQuery
    {
        internal SDK.GroupsQuery Obj { get; } = obj;

		public bool Active
		{
			get => Obj.Active;
			set => Obj.Active = value;
		}

		public bool ActiveSpecified
		{
			get => Obj.ActiveSpecified;
			set => Obj.ActiveSpecified = value;
		}

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}
    }
}
