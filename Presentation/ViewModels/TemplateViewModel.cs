namespace Presentation.ViewModels
{   /// <summary>
    /// Модель представлення шаблона
    /// </summary>
    public class TemplateViewModel
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
       // public double SizeFile { get; set; }
        public Dictionary<string, string> BookmarksFile { get; set; }
        public byte[] ContentFile { get; set; }
    }
}
