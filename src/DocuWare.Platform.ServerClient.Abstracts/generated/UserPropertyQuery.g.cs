using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserPropertyQuery(DocuWare.Platform.ServerClient.UserPropertyQuery obj) : IUserPropertyQuery
    {
        internal DocuWare.Platform.ServerClient.UserPropertyQuery Obj { get; } = obj;

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public bool Active
        {
            get => Obj.Active;
            set => Obj.Active = value;
        }

        public string FirstName
        {
            get => Obj.FirstName;
            set => Obj.FirstName = value;
        }

        public string LastName
        {
            get => Obj.LastName;
            set => Obj.LastName = value;
        }

        public string Salutation
        {
            get => Obj.Salutation;
            set => Obj.Salutation = value;
        }
    }
}
