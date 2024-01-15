using Presentation.Models;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class LoadDocumentPresenter
    {
        private ILoadDocument _loadDocView;
        public LoadDocumentPresenter(ILoadDocument loadDocView)
        {
            _loadDocView = loadDocView;
        }
    }
}
