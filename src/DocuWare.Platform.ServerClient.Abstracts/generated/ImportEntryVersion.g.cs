using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportEntryVersion(SDK.ImportEntryVersion obj) : IImportEntryVersion
    {
        internal SDK.ImportEntryVersion Obj { get; } = obj;

		public int Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}

		public ImportEntryVersionStatus Status
		{
			get => new mportEntryVersionStatus(Obj.Status);
			set => Obj.Status = ((mportEntryVersionStatus)value).Obj;
		}
    }
}
