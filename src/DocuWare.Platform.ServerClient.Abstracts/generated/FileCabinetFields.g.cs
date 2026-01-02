using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetFields(DocuWare.Platform.ServerClient.FileCabinetFields obj) : IFileCabinetFields
    {
        internal DocuWare.Platform.ServerClient.FileCabinetFields Obj { get; } = obj;

        public List<IFileCabinetField> Field
        {
            get => Obj.Field.Select(x => new FileCabinetField(x) as IFileCabinetField).ToList();
            set => Obj.Field = value.Select(x => ((FileCabinetField)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
