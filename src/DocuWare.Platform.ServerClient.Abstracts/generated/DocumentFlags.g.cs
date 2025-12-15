using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentFlags(SDK.DocumentFlags obj) : IDocumentFlags
    {
        internal SDK.DocumentFlags Obj { get; } = obj;

        public bool IsCold
        {
            get => Obj.IsCold;
            set => Obj.IsCold = value;
        }

        public bool IsDBRecord
        {
            get => Obj.IsDBRecord;
            set => Obj.IsDBRecord = value;
        }

        public bool IsCheckedOut
        {
            get => Obj.IsCheckedOut;
            set => Obj.IsCheckedOut = value;
        }

        public bool IsCopyRightProtected
        {
            get => Obj.IsCopyRightProtected;
            set => Obj.IsCopyRightProtected = value;
        }

        public bool IsVoiceAvailable
        {
            get => Obj.IsVoiceAvailable;
            set => Obj.IsVoiceAvailable = value;
        }

        public bool HasAppendedDocuments
        {
            get => Obj.HasAppendedDocuments;
            set => Obj.HasAppendedDocuments = value;
        }

        public bool IsProtected
        {
            get => Obj.IsProtected;
            set => Obj.IsProtected = value;
        }

        public bool IsDeleted
        {
            get => Obj.IsDeleted;
            set => Obj.IsDeleted = value;
        }

        public bool IsEmail
        {
            get => Obj.IsEmail;
            set => Obj.IsEmail = value;
        }
    }
}
