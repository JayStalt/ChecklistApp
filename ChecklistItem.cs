namespace CheckListApp_LH
{
    public class ChecklistItem
    {
        public int Id { get; }
        public string Text { get; }
        public bool Completed { get; set; }

        public ChecklistItem(int id, string text, bool completed)
        {
            Id = id;
            Text = text;
            Completed = completed;
        }

        public override string ToString()
        {
            return Completed ? "✔ " + Text : Text;
        }
    }
}
