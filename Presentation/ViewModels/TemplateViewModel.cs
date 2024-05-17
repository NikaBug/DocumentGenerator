namespace Presentation.ViewModels
{   /// <summary>
    /// Модель представлення шаблона
    /// </summary>
    public class TemplateViewModel
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public byte[] ContentFile { get; set; }
        public Dictionary<string, string> BookmarksFile { get; set; }
    }
}
