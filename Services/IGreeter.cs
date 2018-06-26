namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheday();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfTheday()
        {
            return "A very warm welcome from DC";
        }
    }
}