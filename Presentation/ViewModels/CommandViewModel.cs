namespace Presentation.ViewModels
{   /// <summary>
    /// Модель представлення команди
    /// </summary>
    public class CommandViewModel
    {
        public string NameCommand { get; set; }
        public TemplateViewModel InputTemplate { get; set; }
        public TemplateViewModel OutputTemplate { get; set; }
        public Dictionary<string, string> CommandSetting { get; set; }
    }
}
