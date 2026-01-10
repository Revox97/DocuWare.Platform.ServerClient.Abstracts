using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateProcess(DocuWare.Platform.ServerClient.BatchUpdateProcess obj) : IBatchUpdateProcess
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateProcess Obj { get; } = obj;

        public IBatchUpdateSource Source
        {
            get => throw new NotSupportedException("This property is not supported in the Abstracts library at the moment. Use SDK library for this functionality.");
            set => throw new NotSupportedException("This property is not supported in the Abstracts library at the moment. Use SDK library for this functionality.");
        }

        public IBatchUpdateProcessData Data
        {
            get => new BatchUpdateProcessData(Obj.Data);
            set => Obj.Data = ((BatchUpdateProcessData)value).Obj;
        }
    }
}
