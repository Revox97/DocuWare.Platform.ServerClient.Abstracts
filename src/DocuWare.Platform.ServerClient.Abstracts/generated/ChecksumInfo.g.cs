using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ChecksumInfo(DocuWare.Platform.ServerClient.ChecksumInfo obj) : IChecksumInfo
    {
        internal DocuWare.Platform.ServerClient.ChecksumInfo Obj { get; } = obj;

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
