using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroTutorial
{
    public class ShellViewModel : Conductor<Screen>.Collection.AllActive
    {
        private GreetingsMessageProvider _greetingsMessageProvider;
        private Operations _myOperations;

        public HeaderViewModel HeaderViewModel { get; }
        public ContentViewModel ContentViewModel { get; }

        public ShellViewModel(
            GreetingsMessageProvider greetingsMessageProvider,
            Operations myOperations,
            HeaderViewModel headerViewModel,
            ContentViewModel contentViewModel
            )
        {


            _greetingsMessageProvider = greetingsMessageProvider;
            _myOperations = myOperations;

            HeaderViewModel = headerViewModel;
            ContentViewModel = contentViewModel;

            Items.AddRange(new Screen[] { HeaderViewModel, ContentViewModel });

        }

        private WindowState _windowState;

        public WindowState WindowState
        {
            get { return _windowState; }
            set
            {
                _windowState = value;
                NotifyOfPropertyChange(() => WindowState);
            }
        }

        public void DragWindow()
        {
            Window shellView = GetView(null) as Window;

            shellView.DragMove();
        }

        public void MaximizeWindow()
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        public void MinimizeWindow()
        {
            WindowState = WindowState.Minimized;
        }

        public void CloseWindow()
        {
            Application.Current.Shutdown();
        }

        #region CommentedStuff

        //public string GreetingsMessage => _greetingsMessageProvider.Get();

        //public string ButtonText => "Hello";
        //private string _title = ".NET Guide";

        //public string Title
        //{
        //    get => _title;
        //    set => Set(ref _title, value);
        //}

        //public void HelloClicked(object args)
        //{
        //    Title = "Updated .NET Guide title";
        //}

        #endregion

    }
}
