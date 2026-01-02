using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AppendActionParameters(DocuWare.Platform.ServerClient.AppendActionParameters obj) : IAppendActionParameters
    {
        internal DocuWare.Platform.ServerClient.AppendActionParameters Obj { get; } = obj;

        public List<IAppendActionDocuments> DocumentsInFront
        {
            get => Obj.DocumentsInFront.Select(x => new AppendActionDocuments(x) as IAppendActionDocuments).ToList();
            set => Obj.DocumentsInFront = value.Select(x => ((AppendActionDocuments)x).Obj).ToList();
        }

        public List<IAppendActionDocuments> DocumentsAtBack
        {
            get => Obj.DocumentsAtBack.Select(x => new AppendActionDocuments(x) as IAppendActionDocuments).ToList();
            set => Obj.DocumentsAtBack = value.Select(x => ((AppendActionDocuments)x).Obj).ToList();
        }
    }
}
