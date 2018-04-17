namespace yazLab1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        public void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekrarAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimlendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dönmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağa90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sola90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutlandırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Redq = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 412);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(4, 3);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(829, 325);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.filtrelerToolStripMenuItem,
            this.biçimlendirmeToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.dosyaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.tekrarAçToolStripMenuItem});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dosyaToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_16038985_stock_illustration_blue_file_folder_icon;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.açToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.açToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_46017993_stock_illustration_look_in_the_mirror_icon;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.kaydetToolStripMenuItem.Image = global::yazLab1.Properties.Resources.save_icon_5;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // tekrarAçToolStripMenuItem
            // 
            this.tekrarAçToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tekrarAçToolStripMenuItem.Image = global::yazLab1.Properties.Resources.reopen_open_folder_operating_512;
            this.tekrarAçToolStripMenuItem.Name = "tekrarAçToolStripMenuItem";
            this.tekrarAçToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tekrarAçToolStripMenuItem.Text = "Tekrar Aç";
            this.tekrarAçToolStripMenuItem.Click += new System.EventHandler(this.tekrarAçToolStripMenuItem_Click);
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griToolStripMenuItem,
            this.negatifToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtrelerToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_72588313_stock_illustration_flat_icon_of_paint_brush1;
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.griToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_116195416_stock_illustration_landscape_photo_icon;
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.Image = global::yazLab1.Properties.Resources._40491134_35_mm_negatif_film_simgesi_işareti__yuvarlak_ve_kare_kare_düğmeleri_sembolü__vektör_çizim;
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.negatifToolStripMenuItem.Text = "Negatif";
            this.negatifToolStripMenuItem.Click += new System.EventHandler(this.negatifToolStripMenuItem_Click);
            // 
            // biçimlendirmeToolStripMenuItem
            // 
            this.biçimlendirmeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.biçimlendirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aynaToolStripMenuItem,
            this.dönmeToolStripMenuItem,
            this.boyutlandırmaToolStripMenuItem});
            this.biçimlendirmeToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biçimlendirmeToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_90357008_stock_illustration_flat_landscape_photo_icon_vector1;
            this.biçimlendirmeToolStripMenuItem.Name = "biçimlendirmeToolStripMenuItem";
            this.biçimlendirmeToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.biçimlendirmeToolStripMenuItem.Text = "Biçimlendirme";
            // 
            // aynaToolStripMenuItem
            // 
            this.aynaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aynaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatayToolStripMenuItem,
            this.dikeyToolStripMenuItem});
            this.aynaToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_71519315_stock_illustration_hand_mirror_icon;
            this.aynaToolStripMenuItem.Name = "aynaToolStripMenuItem";
            this.aynaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aynaToolStripMenuItem.Text = "Ayna";
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.Image = global::yazLab1.Properties.Resources.dönme21;
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.yatayToolStripMenuItem.Text = "Yatay";
            this.yatayToolStripMenuItem.Click += new System.EventHandler(this.yatayToolStripMenuItem_Click);
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.Image = global::yazLab1.Properties.Resources.dönme22;
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            this.dikeyToolStripMenuItem.Click += new System.EventHandler(this.dikeyToolStripMenuItem_Click);
            // 
            // dönmeToolStripMenuItem
            // 
            this.dönmeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.dönmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağa90ToolStripMenuItem,
            this.sola90ToolStripMenuItem});
            this.dönmeToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_23800867_stock_illustration_4_arrow_pictogram_refresh_reload;
            this.dönmeToolStripMenuItem.Name = "dönmeToolStripMenuItem";
            this.dönmeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dönmeToolStripMenuItem.Text = "Dönme";
            // 
            // sağa90ToolStripMenuItem
            // 
            this.sağa90ToolStripMenuItem.Image = global::yazLab1.Properties.Resources.dönme;
            this.sağa90ToolStripMenuItem.Name = "sağa90ToolStripMenuItem";
            this.sağa90ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sağa90ToolStripMenuItem.Text = "90 derece sağa";
            this.sağa90ToolStripMenuItem.Click += new System.EventHandler(this.sağa90ToolStripMenuItem_Click);
            // 
            // sola90ToolStripMenuItem
            // 
            this.sola90ToolStripMenuItem.Image = global::yazLab1.Properties.Resources.dönme2;
            this.sola90ToolStripMenuItem.Name = "sola90ToolStripMenuItem";
            this.sola90ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sola90ToolStripMenuItem.Text = "90 derece sola";
            this.sola90ToolStripMenuItem.Click += new System.EventHandler(this.sola90ToolStripMenuItem_Click);
            // 
            // boyutlandırmaToolStripMenuItem
            // 
            this.boyutlandırmaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.boyutlandırmaToolStripMenuItem.Image = global::yazLab1.Properties.Resources.dönme211;
            this.boyutlandırmaToolStripMenuItem.Name = "boyutlandırmaToolStripMenuItem";
            this.boyutlandırmaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.boyutlandırmaToolStripMenuItem.Text = "Boyutlandırma";
            this.boyutlandırmaToolStripMenuItem.Click += new System.EventHandler(this.boyutlandırmaToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.histogramToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.histogramToolStripMenuItem.Image = global::yazLab1.Properties.Resources.depositphotos_77767764_stock_illustration_histogram_icon;
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // Redq
            // 
            this.Redq.AutoSize = true;
            this.Redq.Checked = true;
            this.Redq.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Redq.Location = new System.Drawing.Point(1207, 36);
            this.Redq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Redq.Name = "Redq";
            this.Redq.Size = new System.Drawing.Size(66, 18);
            this.Redq.TabIndex = 4;
            this.Redq.TabStop = true;
            this.Redq.Text = "Filtresiz";
            this.Redq.UseVisualStyleBackColor = true;
            this.Redq.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Green.Location = new System.Drawing.Point(1207, 88);
            this.Green.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(48, 18);
            this.Green.TabIndex = 5;
            this.Green.Text = "Yeşil";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1204, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Renk Kanalları";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Blue.Location = new System.Drawing.Point(1207, 115);
            this.Blue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(51, 18);
            this.Blue.TabIndex = 7;
            this.Blue.Text = "Mavi";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(1207, 60);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 18);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Kırmızı";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 460);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.Name = "R";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Lime;
            series2.Name = "G";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Blue;
            series3.Name = "B";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Color = System.Drawing.Color.Cyan;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "C";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Color = System.Drawing.Color.Magenta;
            series5.Legend = "Legend1";
            series5.Name = "M";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Color = System.Drawing.Color.Yellow;
            series6.Legend = "Legend1";
            series6.Name = "Y";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.Color = System.Drawing.Color.Black;
            series7.Legend = "Legend1";
            series7.MarkerColor = System.Drawing.Color.Black;
            series7.Name = "K";
            series7.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(1309, 245);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Redq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "PHOTOSHOP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biçimlendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dönmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyutlandırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağa90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sola90ToolStripMenuItem;
        private System.Windows.Forms.RadioButton Redq;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tekrarAçToolStripMenuItem;
        public static System.Windows.Forms.PictureBox pictureBox1;
    }
}

