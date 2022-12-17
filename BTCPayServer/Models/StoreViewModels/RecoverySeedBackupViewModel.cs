
namespace BTCPayServer.Models.StoreViewModels
{
    public class RecoverySeedBackupViewModel
    {
        public string CryptoCode { get; set; }
        public string Mnemonic { get; set; }
        public string Passphrase { get; set; }
        public string ReturnUrl { get; set; }
        public bool IsStored { get; set; }
        public bool RequireConfirm { get; set; } = true;

        public string[] Words
        {
            get => Mnemonic.Split((char[])null, System.StringSplitOptions.RemoveEmptyEntries);
        }
        public string [] ShuffleWords {
            get {
                var rng = new System.Random();
                return rng.Shuffle(Words);
            }
        }
    }
}
