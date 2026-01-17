using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RemoteWorkApp
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";

        public Form1() { InitializeComponent(); }

     
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    LoadDataFromFile(currentFilePath);
                }
            }
        }

        private void LoadDataFromFile(string path)
        {
            try
            {
                var lines = File.ReadAllLines(path);
                var data = lines
                    .Select(l => l.Split('='))
                    .Where(p => p.Length == 2)
                    .ToDictionary(p => p[0].Trim(), p => p[1].Trim());

                
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

                MessageBox.Show($"Данные загружены из: {Path.GetFileName(path)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }

   
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.FileName = "Report_Export.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var lines = new List<string> {
                        $"OrgName={txtOrgName.Text}",
                        $"INN={txtInn.Text}",
                        $"KPP={txtKpp.Text}",
                        $"OGRN={txtOgrn.Text}",
                        $"Okved={txtOkved.Text}",
                        $"Address={txtAddress.Text}",
                        $"Phone={txtPhone.Text}",
                        $"TotalEmployees={txtTotal.Text}",
                        $"RemoteEmployees={txtRemote.Text}",
                        $"StartDate={dtpStart.Value.ToShortDateString()}"
                    };
                    File.WriteAllLines(saveFileDialog.FileName, lines);
                    MessageBox.Show("Файл успешно сохранен!");
                }
            }
        }
    }
}