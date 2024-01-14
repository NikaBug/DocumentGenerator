using Domain;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsUI
{
    public partial class FormMain : MaterialForm
    {
        private ITemplateRepository _templateRepository;
        private ICommandRepository _commandRepository;
        public FormMain(ITemplateRepository tempRepository, ICommandRepository cmdRepository)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _templateRepository = tempRepository;
            _commandRepository = cmdRepository;
        }
    }
}