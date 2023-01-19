using System.Windows.Forms;
using System.Drawing;

namespace StockExchangeAlert
{
    public partial class frmBaseForm : Form
    {
        public frmBaseForm()
        {
            InitializeComponent();
        }

        public void ShowErrorMessage(string title, string text)
        {

            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string title, string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowErrorMessage(Label label, string message)
        {
            label.Text = "Error: " + message;
            label.ForeColor = Color.OrangeRed;
        }

        public void ShowSuccessMessage(Label label, string message)
        {
            label.Text = "> " + message;
            label.ForeColor = Color.Lime;
        }
    }
}
