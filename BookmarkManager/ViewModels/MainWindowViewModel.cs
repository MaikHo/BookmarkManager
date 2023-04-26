using ReactiveUI;
using System.Windows.Input;

using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using Avalonia;

namespace BookmarkManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public MainWindowViewModel()
        {
            //await Application.Current.Clipboard.SetTextAsync("Hello World!");

            //var text = await Application.Current.Clipboard.GetTextAsync();
            SaveUrlCommand = ReactiveCommand.Create(async () =>
            {
                // Code here will be executed when the button is clicked.
                var text = await Application.Current.Clipboard.GetTextAsync();
                text.ToString();
            });

            /*
             SaveUrlCommand = ReactiveCommand.Create(() =>
            {
                // Code here will be executed when the button is clicked.                
            });
             */
        }

        public ICommand SaveUrlCommand { get; }

        
    }
}