using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateProcess(DocuWare.Platform.ServerClient.BatchUpdateProcess obj) : IBatchUpdateProcess
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateProcess Obj { get; } = obj;

        public IBatchUpdateSource Source
        {
            get
            {
                Type type = Obj.Source.GetType();
                return type.GetConstructor(BindingFlags.Public, [typeof(SDK.BatchUpdateSource)]).Invoke([Obj.Source]) as IBatchUpdateSource;
            }
            set
            {
                Type type = value.GetType();

                PropertyInfo objPropertyInfo = type.GetProperty("Obj");
                SDK.BatchUpdateSource obj = objPropertyInfo.GetValue(value) as SDK.BatchUpdateSource;

                Obj.Source = obj;
            }
        }

        public IBatchUpdateProcessData Data
        {
            get => new BatchUpdateProcessData(Obj.Data);
            set => Obj.Data = ((BatchUpdateProcessData)value).Obj;
        }
    }
}
