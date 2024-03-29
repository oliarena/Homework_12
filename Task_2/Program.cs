namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel model = new PersonModel();
            PersonView view = new PersonView();
            PersonPresenter presenter = new PersonPresenter(model, view);

            view.GetUserInput();

            Console.ReadKey();
        }
    }
}