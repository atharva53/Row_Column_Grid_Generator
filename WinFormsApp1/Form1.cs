using WinFormsApp1.Controls;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Model instance for the form
        private GridSettingsModel _gridSettings;

        public Form1()
        {
            InitializeComponent();

            // Create model and assign to the control
            _gridSettings = new GridSettingsModel();
            dynamicGridControl1.Model = _gridSettings;
        }
    }
}
