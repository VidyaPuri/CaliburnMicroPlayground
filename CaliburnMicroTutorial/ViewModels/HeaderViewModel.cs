using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicroTutorial
{
    public class HeaderViewModel : Screen
    {
        private IEventAggregator _eventAggregator;
        private GreetingsMessageProvider _greetingsMessageProvider;
        private Operations _Operations;
        private int _SelectedOperationIndex;

        public HeaderViewModel(IEventAggregator eventAggregator, GreetingsMessageProvider greetingsMessageProvider, Operations operations)
        {

            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);

            _greetingsMessageProvider = greetingsMessageProvider;
            //Title = greetingsMessageProvider.Message;
            _Operations = operations;
        }

        #region Handlers 

        //public void Handle(GreetingsMessageProvider message)
        //{
        //    Title = message.Message;
        //}

        #endregion
        #region Properties Initialisation

        public Operations Operations
        {
            get => _Operations;
            set => Set(ref _Operations, value);
        }

        public int SelectedOperationIndex
        {
            get => _SelectedOperationIndex;
            set => Set(ref _SelectedOperationIndex, value);
        }

        public GreetingsMessageProvider Title
        {
            get => _greetingsMessageProvider;
            set => Set(ref _greetingsMessageProvider, value);
        }

        #endregion

        #region Private Methods

        public void RemoveItem()
        {
            if(SelectedOperationIndex >= 0)
                if (Operations.MyOperations.Count > 0)
                    Operations.MyOperations.RemoveAt(SelectedOperationIndex);
            if (SelectedOperationIndex == 0)
                return;
            if (SelectedOperationIndex == -1)
                SelectedOperationIndex = 0;
        }

        #endregion

        #region Commented Stuff

        //public void NavigateToHome()
        //{
        //    _eventAggregator.PublishOnUIThread(new NavigateToMessage(NavigateToEnum.Home));
        //}
        //public void NavigateToSettings()
        //{
        //    _eventAggregator.PublishOnUIThread(new NavigateToMessage(NavigateToEnum.Settings));
        //}

        #endregion
    }
}
