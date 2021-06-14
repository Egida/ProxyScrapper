/*
    $ ProxyScrapper $
    Author > github.com/L1ghtM4n
    Donate > 1Lightx1nLy6DfH3W8WD1g4PugRu92M7GV (Bitcoin)
*/


using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;

namespace ProxyScrapper
{
    public partial class MainForm : Form
    {

        private static readonly RegionInfo[] allRegions = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            .Where(x => !x.Equals(CultureInfo.InvariantCulture)) // Remove the invariant culture as a region cannot be created from it.
            .Where(x => !x.IsNeutralCulture) // Remove nuetral cultures as a region cannot be created from them.
            .Select(x => new RegionInfo(x.LCID))
            .GroupBy(x => x.EnglishName)
            .Select(x => x.First())
            .ToArray();

        public MainForm()
        {
            InitializeComponent();

            // Append countries list to comboBox
            comboBoxProxyCountry.Items.Add("All");
            allRegions.Select(r => comboBoxProxyCountry.Items.Add(r.EnglishName)).ToArray();
            // Select default first element
            this.comboBoxProxyType.SelectedIndex = 0;
            this.comboBoxExportFormat.SelectedIndex = 0;
            this.comboBoxProxyCountry.SelectedIndex = 0;
        }

        private void buttonScrapeProxies_Click(object sender, EventArgs e)
        {
            string[] proxies;
            string countryCode = "All";
            string proxyType = this.comboBoxProxyType.SelectedItem.ToString();
            string countryEnglishName = comboBoxProxyCountry.SelectedItem.ToString();
            if (countryEnglishName != "All")
            {
                countryCode = allRegions.Where(ci => countryEnglishName.Equals(ci.EnglishName)).First().TwoLetterISORegionName;
            } 
            // Handle exceptions
            try
            {
                proxies = Scrapper.Search(proxyType, countryCode);
            } catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Error '{0}'", ex.Message), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Handle zero response
            if (proxies.Length.Equals(0))
            {
                MessageBox.Show(this, string.Format("Proxies not found for '{0}'", countryEnglishName), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Clean table values
            dataGridViewProxies.Rows.Clear();
            // Info
            this.Text = string.Format("ProxyScrapper | Found {0} {1} proxies", proxies.Length, proxyType);
            // Append new values
            foreach (string proxy in proxies)
            {
                string[] result = proxy.Split(':');
                dataGridViewProxies.Rows.Add(result);
            }

        }

        private void buttonExportProxies_Click(object sender, EventArgs e)
        {
            StringBuilder sbOutput = new StringBuilder();
            string exportFormat = this.comboBoxExportFormat.SelectedItem.ToString().ToUpper();
            bool exportText = exportFormat.Equals("TEXT");
            bool exportJson = exportFormat.Equals("JSON");
            string exportFilename = string.Format(
                "{0}-proxies-export.{1}",
                dataGridViewProxies.Rows.Count - 1,
                exportJson ? "json" : "txt"
            );
            // Handle zero items
            if (dataGridViewProxies.Rows.Count < 2)
            {
                MessageBox.Show(this, "No proxies to export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Save proxies
            for (int row = 0; dataGridViewProxies.Rows.Count - 1 > row; row++)
            {
                string host = dataGridViewProxies.Rows[row].Cells[0].Value.ToString();
                string port = dataGridViewProxies.Rows[row].Cells[1].Value.ToString();
                // Append Text
                if (exportText)
                {
                    sbOutput.AppendFormat(
                        "{0}:{1}\n\r",
                        host, port
                    );
                // Append Json
                } else if (exportJson)
                {
                    sbOutput.AppendFormat(
                        "\t{{\n\r\t\t\"host\": \"{0}\",\n\r\t\t\"port\": {1}\n\r\t}},\n\r", 
                        host, port
                    );
                }
            }
            // Format Json
            if (exportJson)
            {
                sbOutput.Remove(sbOutput.Length - 3, 1);
                sbOutput.Insert(0, "[\n\r");
                sbOutput.Insert(sbOutput.Length, "]\n\r");
            }
            // Write data
            File.WriteAllText(exportFilename, sbOutput.ToString());
            // Info
            MessageBox.Show(this, string.Format("{0} saved!", exportFilename), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/L1ghtM4n");
        }

    }
}
