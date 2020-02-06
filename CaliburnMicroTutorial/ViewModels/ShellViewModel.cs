using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
