using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RemoteWorkApp
{
    public partial class Form1 : Form
    {
        private string filePath = "C:\\Users\\student\\source\\repos\\RemoteWorkApp\\data.txt";

        public Form1() { InitializeComponent(); }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath)) return;
            var data = File.ReadAllLines(filePath).Select(l => l.Split('=')).ToDictionary(p => p[0], p => p[1]);

            txtOrgName.Text = data["OrgName"];
            txtInn.Text = data["INN"];
            txtKpp.Text = data["KPP"];
            txtOgrn.Text = data["OGRN"];
            txtOkved.Text = data["Okved"];
            txtAddress.Text = data["Address"];
            txtPhone.Text = data["Phone"];
            txtTotal.Text = data["TotalEmployees"];
            txtRemote.Text = data["RemoteEmployees"];
            dtpStart.Value = DateTime.Parse(data["StartDate"]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var lines = new List<string> {
                $"OrgName={txtOrgName.Text}", $"INN={txtInn.Text}", $"KPP={txtKpp.Text}",
                $"OGRN={txtOgrn.Text}", $"Okved={txtOkved.Text}", $"Address={txtAddress.Text}",
                $"Phone={txtPhone.Text}", $"TotalEmployees={txtTotal.Text}",
                $"RemoteEmployees={txtRemote.Text}", $"StartDate={dtpStart.Value.ToShortDateString()}"
            };
            File.WriteAllLines(filePath, lines);
            MessageBox.Show("Данные сохранены в проект формата хранения.");
        }
    }
}