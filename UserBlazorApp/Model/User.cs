namespace UserBlazorApp.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName
        {
            get
            {
                var nameParts = Name?.Split(' ');
                return nameParts?.Length > 1 ? nameParts[1] : "";
            }
        }
    }
}
