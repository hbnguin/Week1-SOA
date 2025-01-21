using Client_SOA_BN.MyService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_SOA_BN
{
    public partial class Form1 : Form
    {
        public ServerRefSoapClient myService;
        public Form1()
        {
            InitializeComponent();
            myService = new ServerRefSoapClient();
        }
        private void InvokeService<T>(Func<T> serviceCall)
        {
            try
            {
                // Gọi service và lấy kết quả
                var result = serviceCall();
                resultDataGridView.DataSource = null;
                // Cập nhật DataGridView
                if (result != null)
                {
                    resultDataGridView.DataSource = null;
                    if (result is ArrayOfString results)
                    {
                        resultDataGridView.Rows.Clear();
                        resultDataGridView.Columns.Clear();
                        resultDataGridView.Columns.Add("Language", "Language");
                        foreach(string mystring in results)
                        {
                            resultDataGridView.Rows.Add(mystring);
                        }
                        return;
                    }
                    resultDataGridView.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Service returned no data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show($"Error: {ex.Message}", "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void serviceButton1_Click(object sender, EventArgs e)
        {
            InvokeService(() => myService.GetCountries());
        }

        private void serviceButton2_Click(object sender, EventArgs e)
        {
            string code = service2TextBox.Text;
            InvokeService(() => myService.GetCountryByCode(code));
        }

        private void serviceButton3_Click(object sender, EventArgs e)
        {
            string countryName = service5TextBox.Text;
            InvokeService(() => myService.PopulationOfCountry(countryName));
        }

        private void serviceButton4_Click(object sender, EventArgs e)
        {
            string country = service4TextBox.Text;
            InvokeService(() => myService.GetCitiesByCountry(country));
        }

        private void serviceButton5_Click(object sender, EventArgs e)
        {
            string name = service3TextBox.Text;
            InvokeService(() => myService.GetCitiesByName(name));
        }

        private void serviceButton6_Click(object sender, EventArgs e)
        {
            int min, max;
            if(!int.TryParse(service6TextBox_1.Text, out min) 
                || !int.TryParse(service6TextBox_2.Text, out max))
            {
                MessageBox.Show("Again");
                return;
            }
            InvokeService(() => myService.GetCityByPopulation(min, max));
        }

        private void serviceButton7_Click(object sender, EventArgs e)
        {
            string countryCode = service7TextBox.Text;
            InvokeService(() => myService.OfficialLanguagesOfCountries(countryCode));
        }
    }
}
