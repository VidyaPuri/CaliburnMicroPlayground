namespace CaliburnMicroTutorial
{
    public sealed class NavigateToMessage
    {
        public NavigateToMessage(NavigateToEnum navigateTo)
        {
            NavigateTo = navigateTo;
        }

        public NavigateToEnum NavigateTo { get; }
    }
    public enum NavigateToEnum
        {
            Home,
            Settings
        }
}