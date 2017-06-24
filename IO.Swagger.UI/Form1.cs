using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.UI.Properties;
using Newtonsoft.Json;

namespace IO.Swagger.UI
{
    public partial class Form1 : Form
    {
        private ClientsApi api;
        public Form1()
        {
            api = new ClientsApi("https://generator.swagger.io/api");
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sett = Settings.Default;
            txtJsonBody.Text = sett.Content;
            txtProjectName.Text = sett.Project;
            LoadClients();
        }

        private async void LoadClients()
        {
            try
            {
                var opts = await api.ClientOptionsAsync();
                cbLanguages.DataSource = opts;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            await Generate();
        }

        private async Task Generate()
        {
            if (cbLanguages.SelectedItem == null)
            {
                MessageBox.Show(@"Selecciona un lenguaje");
                return;
            }
            var lang = (string)cbLanguages.SelectedItem;
            var json = txtJsonBody.Text;
            var project = txtProjectName.Text;
            var obj = JsonConvert.DeserializeObject(json);

            var response = await api.GenerateClientAsync(lang, new Body(obj, new Dictionary<string, string>
            {
                {"packageName", project}
            }));
            var zip = GetFilenameToSave();
            if (string.IsNullOrEmpty(zip)) return;

            using (var client = new WebClient())
            {
                await client.DownloadFileTaskAsync(response.Link, zip);
            }
            SaveSetting();
            Process.Start(zip);
        }
        private string GetFilenameToSave()
        {
            var saveFile = new SaveFileDialog
            {
                Filter = @"Zip Files (*.zip)|*.zip|All Files (*.*)|*.*",
            };
            if (saveFile.ShowDialog() != DialogResult.OK) return null;
            return saveFile.FileName;
        }

        private void SaveSetting()
        {
            var sett = Settings.Default;
            sett.Content = txtJsonBody.Text;
            sett.Project = txtProjectName.Text;
            sett.Save();
        }
    }
}
