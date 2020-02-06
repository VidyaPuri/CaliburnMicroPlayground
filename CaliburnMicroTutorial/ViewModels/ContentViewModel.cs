using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicroTutorial
{
     public class ContentViewModel : Screen
    {
        private IEventAggregator _eventAggregator;
        private GreetingsMessageProvider _greetingsMessageProvider;
        private string _Title;
        private string _NewMessage = " ";
        private Operations _Operations;
        private string _OperationName;
        private double _OperationVal;

        public ContentViewModel(IEventAggregator eventAggregator, GreetingsMessageProvider greetingsMessageProvider, Operations myOperations)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);

            _greetingsMessageProvider = greetingsMessageProvider;
            _Operations = myOperations;
        }

        #region Properties Initialisation 
        public string NewMessage
        {
            get => _NewMessage;
            set => Set(ref _NewMessage, value);
        }
        public GreetingsMessageProvider Title
        {
            get => _greetingsMessageProvider;
            set => Set(ref _greetingsMessageProvider, value);
        }

        public string OperationName
        {
            get => _OperationName;
            set => Set(ref _OperationName, value);
        }

        public double OperationVal
        {
            get => _OperationVal;
            set => Set(ref _OperationVal, value);
        }

        public Operations Operations
        {
            get => _Operations;
            set => Set(ref _Operations, value);
        }

        #endregion

        #region Private Methods

        // Ads new Operation to list
        public void AddOperation()
        {
            var newOperation = new Operation();

            newOperation.Name = OperationName;
            newOperation.Val = OperationVal;

            Operations.MyOperations.Add(newOperation);
        }

        /// <summary>
        /// Gets the message from MessageProvider class
        /// </summary>
        public void MessageProvider()
        {
            Title = _greetingsMessageProvider;
        }

        /// <summary>
        /// Sets a new message property to MessageProvider and publish it on UIThread
        /// </summary>
        public void SetMessage()
        {
            _greetingsMessageProvider.Message = NewMessage;
            //_eventAggregator.PublishOnUIThread(_greetingsMessageProvider);
        }

        #endregion


        #region Handlers

        /// <summary>
        /// Handles the changes on the GreetingsMessageProvider
        /// </summary>
        /// <param name="message"></param>
        //public void Handle(GreetingsMessageProvider message)
        //{
        //    Title = message;
        //}

        #endregion
    }
}
