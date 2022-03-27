using System;
using System.IO;
using System.Text;

namespace Encryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // file encryption

            const string dataToProtect = "This is a bunch of secret content!";
            var dataToProtectAsArray = Encoding.Unicode.GetBytes(dataToProtect);
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDataFile.txt");
            File.WriteAllText(fileName, dataToProtect);
            File.Encrypt(fileName);

            // Data protection BS
            //var wdpEncryptedData = ProtectedData.
        }
    }
}
