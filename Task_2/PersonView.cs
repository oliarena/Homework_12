namespace Task_2
{
    public delegate void UserInputDelegate(string name);

    public class PersonView
    {
        public event UserInputDelegate OnUserInputEntered;

        public void GetUserInput()
        {
            Console.Write("Please,enter person's name: ");
            string? name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Try again ... ");
                name = Console.ReadLine();
            }

            OnUserInputEntered.Invoke(name);
        }

        public void PrintUpdatedInfo(string name)
        {
            Console.WriteLine($"Person's name sucessfully updated :{name}");
        }
    }
}