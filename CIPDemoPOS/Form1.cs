using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cipeinet;

namespace CIPDemoPOS
{
    public partial class form_DemoPOS : Form
    {
        public form_DemoPOS()
        {
            InitializeComponent();
        }

        private void btn_CreditSale_Click(object sender, EventArgs e)
        {
            EasyIntegrator easyIntegrator = new EasyIntegrator();
            string setup = System.IO.File.ReadAllText("ExternalRefs\\setup.txt");
            easyIntegrator.LoadSetup(setup);
            easyIntegrator.Clear();
            if (!string.IsNullOrWhiteSpace(txtBox_Amount.Text))
            {
                easyIntegrator.transFields.AmountTotal = Double.Parse(txtBox_Amount.Text);
                easyIntegrator.CreditSale();
                txtBox_ResultMessage.Text = easyIntegrator.resultsFields.ResultMessage;
                txtBox_ResultStatus.Text = easyIntegrator.resultsFields.ResultStatus.ToString();
            }
            else
            {
                MessageBox.Show("Amount cannot be null or empty", "Empty Amount");
            }

        }
    }
}
