using System;
using System.Collections.Generic;
using System.Text;

namespace YetAnotherMinecraftLauncher.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public void Test()
        {
            Console.WriteLine("");
        }
    }
}
