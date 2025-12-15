using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ChecksumInfo(SDK.ChecksumInfo obj) : IChecksumInfo
    {
        internal SDK.ChecksumInfo Obj { get; } = obj;

		public string ChecksumValue
		{
			get => Obj.ChecksumValue;
			set => Obj.ChecksumValue = value;
		}

		public string ChecksumAlgorithm
		{
			get => Obj.ChecksumAlgorithm;
			set => Obj.ChecksumAlgorithm = value;
		}
    }
}
