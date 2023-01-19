using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace TSEAlert.Forms
{
    public partial class frmLoading : Form
    {
        private Action _worker { get; set; }

        public frmLoading(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            _worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(_worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
