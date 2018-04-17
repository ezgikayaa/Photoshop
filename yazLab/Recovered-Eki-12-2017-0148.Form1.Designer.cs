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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimlendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dönmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutlandırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağa90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sola90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(646, 338);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(241, 250);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 346);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 279);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.filtrelerToolStripMenuItem,
            this.biçimlendirmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.açToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.açToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.açToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.filtrelerToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griToolStripMenuItem,
            this.negatifToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.griToolStripMenuItem.Text = "Gri";
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negatifToolStripMenuItem.Text = "Negatif";
            // 
            // biçimlendirmeToolStripMenuItem
            // 
            this.biçimlendirmeToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.biçimlendirmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aynaToolStripMenuItem,
            this.dönmeToolStripMenuItem,
            this.boyutlandırmaToolStripMenuItem});
            this.biçimlendirmeToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biçimlendirmeToolStripMenuItem.Name = "biçimlendirmeToolStripMenuItem";
            this.biçimlendirmeToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.biçimlendirmeToolStripMenuItem.Text = "Biçimlendirme";
            // 
            // aynaToolStripMenuItem
            // 
            this.aynaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aynaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatayToolStripMenuItem,
            this.dikeyToolStripMenuItem});
            this.aynaToolStripMenuItem.Name = "aynaToolStripMenuItem";
            this.aynaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aynaToolStripMenuItem.Text = "Ayna";
            // 
            // dönmeToolStripMenuItem
            // 
            this.dönmeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.dönmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağa90ToolStripMenuItem,
            this.sola90ToolStripMenuItem});
            this.dönmeToolStripMenuItem.Name = "dönmeToolStripMenuItem";
            this.dönmeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dönmeToolStripMenuItem.Text = "Dönme";
            // 
            // boyutlandırmaToolStripMenuItem
            // 
            this.boyutlandırmaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.boyutlandırmaToolStripMenuItem.Name = "boyutlandırmaToolStripMenuItem";
            this.boyutlandırmaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.boyutlandırmaToolStripMenuItem.Text = "Boyutlandırma";
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yatayToolStripMenuItem.Text = "Yatay";
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            // 
            // sağa90ToolStripMenuItem
            // 
            this.sağa90ToolStripMenuItem.Name = "sağa90ToolStripMenuItem";
            this.sağa90ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sağa90ToolStripMenuItem.Text = "90 derece Sağa";
            // 
            // sola90ToolStripMenuItem
            // 
            this.sola90ToolStripMenuItem.Name = "sola90ToolStripMenuItem";
            this.sola90ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sola90ToolStripMenuItem.Text = "90 derece Sola";
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(764, 67);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(54, 17);
            this.Red.TabIndex = 4;
            this.Red.TabStop = true;
            this.Red.Text = "Kırmızı";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(764, 90);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(47, 17);
            this.Green.TabIndex = 5;
            this.Green.TabStop = true;
            this.Green.Text = "Yeşil";
            this.Green.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 600);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Green;
    }
}

