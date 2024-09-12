using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void btnCallWebAPI_Click(object sender, EventArgs e)
        {
             HttpClient client = new HttpClient();
            string path = "https://apitester.ir/api/categories";
           
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                var categorylist = response.Content.ReadAsAsync<List<CategoryModel>>().Result;
            }
        }

        public T FromByteArray<T>(byte[] data)
        {
            if (data == null)
                return default(T);
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }

        private void btnCallWebAPIProducts_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string path = "https://apitester.ir/api/Products";

            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<List<ProductModel>>().Result;
            }
        }
    }
}
