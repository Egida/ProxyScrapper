/*
    $ ProxyScrapper $
    Author > github.com/L1ghtM4n
    Donate > 1Lightx1nLy6DfH3W8WD1g4PugRu92M7GV (Bitcoin)
*/


using System.Windows.Forms;

namespace ProxyScrapper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProxies = new System.Windows.Forms.DataGridView();
            this.ColumnHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProxies = new System.Windows.Forms.Panel();
            this.groupBoxScrapper = new System.Windows.Forms.GroupBox();
            this.labelProxyCountry = new System.Windows.Forms.Label();
            this.comboBoxProxyCountry = new System.Windows.Forms.ComboBox();
            this.buttonScrapeProxies = new System.Windows.Forms.Button();
            this.labelProxyType = new System.Windows.Forms.Label();
            this.comboBoxProxyType = new System.Windows.Forms.ComboBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.buttonExportProxies = new System.Windows.Forms.Button();
            this.labelProxyExport = new System.Windows.Forms.Label();
            this.comboBoxExportFormat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxies)).BeginInit();
            this.panelProxies.SuspendLayout();
            this.groupBoxScrapper.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.groupBoxExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProxies
            // 
            this.dataGridViewProxies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProxies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewProxies.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProxies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProxies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHost,
            this.ColumnPort});
            this.dataGridViewProxies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProxies.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProxies.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.dataGridViewProxies.Name = "dataGridViewProxies";
            this.dataGridViewProxies.Size = new System.Drawing.Size(441, 307);
            this.dataGridViewProxies.TabIndex = 0;
            // 
            // ColumnHost
            // 
            this.ColumnHost.HeaderText = "Host";
            this.ColumnHost.Name = "ColumnHost";
            // 
            // ColumnPort
            // 
            this.ColumnPort.HeaderText = "Port";
            this.ColumnPort.Name = "ColumnPort";
            // 
            // panelProxies
            // 
            this.panelProxies.Controls.Add(this.dataGridViewProxies);
            this.panelProxies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProxies.Location = new System.Drawing.Point(198, 0);
            this.panelProxies.Name = "panelProxies";
            this.panelProxies.Size = new System.Drawing.Size(441, 307);
            this.panelProxies.TabIndex = 3;
            // 
            // groupBoxScrapper
            // 
            this.groupBoxScrapper.Controls.Add(this.labelProxyCountry);
            this.groupBoxScrapper.Controls.Add(this.comboBoxProxyCountry);
            this.groupBoxScrapper.Controls.Add(this.buttonScrapeProxies);
            this.groupBoxScrapper.Controls.Add(this.labelProxyType);
            this.groupBoxScrapper.Controls.Add(this.comboBoxProxyType);
            this.groupBoxScrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxScrapper.Location = new System.Drawing.Point(10, 10);
            this.groupBoxScrapper.Name = "groupBoxScrapper";
            this.groupBoxScrapper.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxScrapper.Size = new System.Drawing.Size(178, 158);
            this.groupBoxScrapper.TabIndex = 1;
            this.groupBoxScrapper.TabStop = false;
            this.groupBoxScrapper.Text = "Scapper";
            // 
            // labelProxyCountry
            // 
            this.labelProxyCountry.AutoSize = true;
            this.labelProxyCountry.Location = new System.Drawing.Point(9, 70);
            this.labelProxyCountry.Name = "labelProxyCountry";
            this.labelProxyCountry.Size = new System.Drawing.Size(46, 13);
            this.labelProxyCountry.TabIndex = 6;
            this.labelProxyCountry.Text = "Country:";
            // 
            // comboBoxProxyCountry
            // 
            this.comboBoxProxyCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProxyCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProxyCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProxyCountry.FormattingEnabled = true;
            this.comboBoxProxyCountry.Location = new System.Drawing.Point(10, 88);
            this.comboBoxProxyCountry.Name = "comboBoxProxyCountry";
            this.comboBoxProxyCountry.Size = new System.Drawing.Size(158, 21);
            this.comboBoxProxyCountry.TabIndex = 5;
            // 
            // buttonScrapeProxies
            // 
            this.buttonScrapeProxies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonScrapeProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScrapeProxies.Location = new System.Drawing.Point(10, 125);
            this.buttonScrapeProxies.Name = "buttonScrapeProxies";
            this.buttonScrapeProxies.Size = new System.Drawing.Size(158, 23);
            this.buttonScrapeProxies.TabIndex = 4;
            this.buttonScrapeProxies.Text = "Search";
            this.buttonScrapeProxies.UseVisualStyleBackColor = true;
            this.buttonScrapeProxies.Click += new System.EventHandler(this.buttonScrapeProxies_Click);
            // 
            // labelProxyType
            // 
            this.labelProxyType.AutoSize = true;
            this.labelProxyType.Location = new System.Drawing.Point(7, 23);
            this.labelProxyType.Name = "labelProxyType";
            this.labelProxyType.Size = new System.Drawing.Size(59, 13);
            this.labelProxyType.TabIndex = 3;
            this.labelProxyType.Text = "Proxy type:";
            // 
            // comboBoxProxyType
            // 
            this.comboBoxProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProxyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProxyType.FormattingEnabled = true;
            this.comboBoxProxyType.Items.AddRange(new object[] {
            "HTTP",
            "HTTPS",
            "SOCKS4",
            "SOCKS5"});
            this.comboBoxProxyType.Location = new System.Drawing.Point(10, 41);
            this.comboBoxProxyType.Name = "comboBoxProxyType";
            this.comboBoxProxyType.Size = new System.Drawing.Size(158, 21);
            this.comboBoxProxyType.TabIndex = 2;
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.labelAuthor);
            this.panelTools.Controls.Add(this.groupBoxExport);
            this.panelTools.Controls.Add(this.groupBoxScrapper);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Margin = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.panelTools.Name = "panelTools";
            this.panelTools.Padding = new System.Windows.Forms.Padding(10);
            this.panelTools.Size = new System.Drawing.Size(198, 307);
            this.panelTools.TabIndex = 3;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAuthor.Location = new System.Drawing.Point(10, 284);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(178, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "github.com/L1ghtM4n";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAuthor.Click += new System.EventHandler(this.labelAuthor_Click);
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Controls.Add(this.buttonExportProxies);
            this.groupBoxExport.Controls.Add(this.labelProxyExport);
            this.groupBoxExport.Controls.Add(this.comboBoxExportFormat);
            this.groupBoxExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxExport.Location = new System.Drawing.Point(10, 168);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxExport.Size = new System.Drawing.Size(178, 105);
            this.groupBoxExport.TabIndex = 1;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Export";
            // 
            // buttonExportProxies
            // 
            this.buttonExportProxies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExportProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportProxies.Location = new System.Drawing.Point(10, 72);
            this.buttonExportProxies.Name = "buttonExportProxies";
            this.buttonExportProxies.Size = new System.Drawing.Size(158, 23);
            this.buttonExportProxies.TabIndex = 7;
            this.buttonExportProxies.Text = "Export";
            this.buttonExportProxies.UseVisualStyleBackColor = true;
            this.buttonExportProxies.Click += new System.EventHandler(this.buttonExportProxies_Click);
            // 
            // labelProxyExport
            // 
            this.labelProxyExport.AutoSize = true;
            this.labelProxyExport.Location = new System.Drawing.Point(7, 23);
            this.labelProxyExport.Name = "labelProxyExport";
            this.labelProxyExport.Size = new System.Drawing.Size(42, 13);
            this.labelProxyExport.TabIndex = 6;
            this.labelProxyExport.Text = "Format:";
            // 
            // comboBoxExportFormat
            // 
            this.comboBoxExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExportFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxExportFormat.FormattingEnabled = true;
            this.comboBoxExportFormat.Items.AddRange(new object[] {
            "Text",
            "Json"});
            this.comboBoxExportFormat.Location = new System.Drawing.Point(9, 41);
            this.comboBoxExportFormat.Name = "comboBoxExportFormat";
            this.comboBoxExportFormat.Size = new System.Drawing.Size(159, 21);
            this.comboBoxExportFormat.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 307);
            this.Controls.Add(this.panelProxies);
            this.Controls.Add(this.panelTools);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ProxyScrapper";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxies)).EndInit();
            this.panelProxies.ResumeLayout(false);
            this.groupBoxScrapper.ResumeLayout(false);
            this.groupBoxScrapper.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.groupBoxExport.ResumeLayout(false);
            this.groupBoxExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewProxies;
        private Panel panelProxies;
        private GroupBox groupBoxScrapper;
        private Button buttonScrapeProxies;
        private Label labelProxyType;
        private ComboBox comboBoxProxyType;
        private Panel panelTools;
        private GroupBox groupBoxExport;
        private Button buttonExportProxies;
        private Label labelProxyExport;
        private ComboBox comboBoxExportFormat;
        private Label labelProxyCountry;
        private ComboBox comboBoxProxyCountry;
        private DataGridViewTextBoxColumn ColumnHost;
        private DataGridViewTextBoxColumn ColumnPort;
        private Label labelAuthor;
    }
}

