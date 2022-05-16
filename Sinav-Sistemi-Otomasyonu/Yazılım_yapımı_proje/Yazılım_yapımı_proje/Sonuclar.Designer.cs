
namespace Yazılım_yapımı_proje
{
    partial class Sonuclar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sonuclar));
            this.dataGrid_sonuc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_sonuc
            // 
            this.dataGrid_sonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_sonuc.Location = new System.Drawing.Point(110, 121);
            this.dataGrid_sonuc.Name = "dataGrid_sonuc";
            this.dataGrid_sonuc.RowHeadersWidth = 51;
            this.dataGrid_sonuc.RowTemplate.Height = 24;
            this.dataGrid_sonuc.Size = new System.Drawing.Size(713, 522);
            this.dataGrid_sonuc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(284, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SONUÇLARINIZ AŞAĞIDAKİ GİBİDİR.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(343, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Öğrenci Menü\'ye Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sonuclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(970, 774);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_sonuc);
            this.DoubleBuffered = true;
            this.Name = "Sonuclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonuclar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}