using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDialogQuery(SDK.RequestDialogQuery obj) : IRequestDialogQuery
    {
        internal SDK.RequestDialogQuery Obj { get; } = obj;

		public List<DialogTypes> DialogTypes
		{
			get => Obj.DialogTypes.Select(x => new ialogTypes(x) as DialogTypes).ToList();
			set => Obj.DialogTypes = value.Select(x => ((ialogTypes)x).Obj).ToList();
		}
    }
}
