using Nomadicooer.Xsd;

namespace Nomadicooer.Tests.Xsd
{
    public interface IConfigs
    {
        public List<ITranslator> Translators { get; set; }
    }
    public interface ITranslator
    {
        public string Platform { get; set; }
        public IStorageStrategy Appid { get; set; }
        public IStorageStrategy Secretkey { get; set; }
    }

    public interface IStorageStrategy
    {
        public string Value { get; set; }
        public bool Encrypt { get; set; }
        public EncryptionKind EncryptionKind { get; set; }
    }

    public enum EncryptionKind
    {
        Aes,
    }
}
