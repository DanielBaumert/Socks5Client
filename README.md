# Socks5Client

```csharp 
Socks5Client client  =  Socks5Client.Connect(
                                  "127.0.0.1", /*socket entry*/
                                   9050, /*socket entry port*/
                                  "google.de", /*target entry*/
                                  80 /*target entry port*/ 
                        );
```


## with Tor - in work
```csharp
public static class Program {
        private const string TOR_PATH = "%appdata%/tor";
        private const string TOR_FILE_NAME = "tor.exe";
#if WIN32
        private const string TOR_WEB_ADDRESS = "https://dist.torproject.org/torbrowser/8.5a6/tor-win32-0.3.5.5-alpha.zip";
#else
        private const string TOR_WEB_ADDRESS = "https://dist.torproject.org/torbrowser/8.5a6/tor-win64-0.3.5.5-alpha.zip";
#endif
        static void Main(string[] args) {
            // StartTorAsync();
            Socks5Client client  =  Socks5Client.Connect("127.0.0.1", 9050, "google.de", 80);

            //Socks5.Create("127.0.0.1", 9050, "google.com", 443);

            Console.ReadKey();
        }

        private static async void StartTorAsync() {
            if (!Directory.Exists(TOR_PATH)) {
                DirectoryInfo directory = new DirectoryInfo(TOR_PATH);
                directory.Create();
                directory.Attributes = FileAttributes.System | FileAttributes.Hidden;
                WebDownload.DownloadFile(TOR_WEB_ADDRESS, Path.Combine(TOR_PATH, TOR_FILE_NAME));

                //  ZipFile.ExtractToDirectory("")
            }
        }

    }
}


```
