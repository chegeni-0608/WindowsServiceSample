using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallWidowsServiceSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CallAddWebService_Click(object sender, EventArgs e)
        {
            Calculatorservice.CalculatorWebServiceSoapClient proxy = new Calculatorservice.CalculatorWebServiceSoapClient();
            int result = proxy.Add(10, 55);
            MessageBox.Show(result.ToString());
        }

        private void btnCallAdvantechWebService_Click(object sender, EventArgs e)
        {
            AdvantechWebService.AdvantechWebServiceLocal service = new AdvantechWebService.AdvantechWebServiceLocal();
            var result = service.CheckURLRedirection();

            CalculatorWebService.CalculatorWebService calculator = new CalculatorWebService.CalculatorWebService();
            calculator.Add(14, 20);
        }
            
    }
}
