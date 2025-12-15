using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateProcess(SDK.BatchUpdateProcess obj) : IBatchUpdateProcess
    {
        internal SDK.BatchUpdateProcess Obj { get; } = obj;

		public IBatchUpdateSource Source
		{
			get => new BatchUpdateSource(Obj.Source);
			set => Obj.Source = ((BatchUpdateSource)value).Obj;
		}

		public IBatchUpdateProcessData Data
		{
			get => new BatchUpdateProcessData(Obj.Data);
			set => Obj.Data = ((BatchUpdateProcessData)value).Obj;
		}
    }
}
