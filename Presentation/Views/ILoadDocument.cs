using Presentation.Models;

namespace Presentation.Views
{
    public interface ILoadDocument
    {
        public string FilePath { get; set; }
        //  public LoadDocument LoadedTemplate { get; set; }
        public event EventHandler Load;
        //public event EventHandler Remove;
    }
}
