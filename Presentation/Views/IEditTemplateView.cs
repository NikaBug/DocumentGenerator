namespace Presentation.Views
{
    public interface IEditTemplateView
    {
        public string oldNameTemplate { get; set; }
        public string newNameTemplate { get; set; }
        public Dictionary<string, string> newBookmarksTemplate { get; set; }
    }
}
