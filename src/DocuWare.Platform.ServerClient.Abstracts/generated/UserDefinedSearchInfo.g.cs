using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserDefinedSearchInfo(DocuWare.Platform.ServerClient.UserDefinedSearchInfo obj) : IUserDefinedSearchInfo
    {
        internal DocuWare.Platform.ServerClient.UserDefinedSearchInfo Obj { get; } = obj;

        public IDialogExpression DialogExpression
        {
            get => new DialogExpression(Obj.DialogExpression);
            set => Obj.DialogExpression = ((DialogExpression)value).Obj;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
