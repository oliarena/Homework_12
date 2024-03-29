namespace Task_2
{
    public delegate void PersonUpdatedDelegate(string name);

    public class PersonModel
    {
        public string? Name { get; set; }

        public event PersonUpdatedDelegate OnPersonUpdated;
        
        public void UpdatePerson(string name)
        {
            Name = name;
            OnPersonUpdated.Invoke(name);
        }
    }
}