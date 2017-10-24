namespace GeeCoeur.Model
{
    public class Work
    {
        public Work()
        {

        }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public void SetWorkInfo(string title, string description   )
        {
            Title = title;
            Description = description;
        }
    }
}