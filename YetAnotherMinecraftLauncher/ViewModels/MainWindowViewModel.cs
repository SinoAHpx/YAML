using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Media.Imaging;
using ReactiveUI;

namespace YetAnotherMinecraftLauncher.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        private Bitmap _versionAvatar = new(@"C:\Users\ahpx\Desktop\AHpxEx.png");
        public Bitmap VersionAvatar
        {
            get => _versionAvatar;
            set => this.RaiseAndSetIfChanged(ref _versionAvatar, value);
        }

        private Bitmap _accountAvatar = new(@"C:\Users\ahpx\Desktop\AHpxEx.png");

        public Bitmap AccountAvatar
        {
            get => _accountAvatar;
            set => this.RaiseAndSetIfChanged(ref _accountAvatar, value);
        }

        private string _accountName = "alwhdawdjklhjawkjdhawkdjh";

        public string AccountName
        {
            get => _accountName;
            set => this.RaiseAndSetIfChanged(ref _accountName, value);
        }

        private string _accountType = "Microsoft";

        public string AccountType
        {
            get => _accountType;
            set => this.RaiseAndSetIfChanged(ref _accountType, value);
        }

        public void Test()
        {
            Console.WriteLine("");
        }
    }
}
