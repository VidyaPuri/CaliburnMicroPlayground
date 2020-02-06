using Caliburn.Micro;

namespace CaliburnMicroTutorial
{
    public class Operations
    {
        public BindableCollection<Operation> MyOperations { get; set; } = new BindableCollection<Operation>
             {
                new Operation()
                {
                    Name = "Prva",
                    Val = 0
                }
            };
    }
}
