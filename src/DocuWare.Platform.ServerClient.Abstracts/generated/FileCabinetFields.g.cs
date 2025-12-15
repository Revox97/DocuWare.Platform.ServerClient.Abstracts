using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetFields(SDK.FileCabinetFields obj) : IFileCabinetFields
    {
        internal SDK.FileCabinetFields Obj { get; } = obj;

        public List<IFileCabinetField> Field
        {
            get => Obj.Field.Select(x => new FileCabinetField(x) as IFileCabinetField).ToList();
            set => Obj.Field = value.Select(x => ((FileCabinetField)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
