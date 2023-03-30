namespace PartialViewsExample.Models
{
    public class ListModel
    {
        public string ListTitle { get; set; } = string.Empty;
        public List<String> ListItems { get; set; } = new List<String>();
    }
}
