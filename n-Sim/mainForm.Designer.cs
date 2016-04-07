namespace n_Sim
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.frameUpdater = new System.Windows.Forms.Timer(this.components);
            this.b1lab = new System.Windows.Forms.Label();
            this.b2lab = new System.Windows.Forms.Label();
            this.b3lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frameUpdater
            // 
            this.frameUpdater.Enabled = true;
            this.frameUpdater.Interval = 33;
            this.frameUpdater.Tick += new System.EventHandler(this.frameUpdater_Tick);
            // 
            // b1lab
            // 
            this.b1lab.AutoSize = true;
            this.b1lab.BackColor = System.Drawing.Color.Transparent;
            this.b1lab.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1lab.ForeColor = System.Drawing.Color.White;
            this.b1lab.Location = new System.Drawing.Point(13, 13);
            this.b1lab.Name = "b1lab";
            this.b1lab.Size = new System.Drawing.Size(42, 15);
            this.b1lab.TabIndex = 0;
            this.b1lab.Text = "Earth";
            // 
            // b2lab
            // 
            this.b2lab.AutoSize = true;
            this.b2lab.BackColor = System.Drawing.Color.Transparent;
            this.b2lab.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2lab.ForeColor = System.Drawing.Color.White;
            this.b2lab.Location = new System.Drawing.Point(13, 31);
            this.b2lab.Name = "b2lab";
            this.b2lab.Size = new System.Drawing.Size(28, 15);
            this.b2lab.TabIndex = 1;
            this.b2lab.Text = "Sun";
            // 
            // b3lab
            // 
            this.b3lab.AutoSize = true;
            this.b3lab.BackColor = System.Drawing.Color.Transparent;
            this.b3lab.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3lab.ForeColor = System.Drawing.Color.White;
            this.b3lab.Location = new System.Drawing.Point(12, 49);
            this.b3lab.Name = "b3lab";
            this.b3lab.Size = new System.Drawing.Size(35, 15);
            this.b3lab.TabIndex = 2;
            this.b3lab.Text = "Mars";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(209, 100);
            this.Controls.Add(this.b3lab);
            this.Controls.Add(this.b2lab);
            this.Controls.Add(this.b1lab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "n-Sim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer frameUpdater;
        private System.Windows.Forms.Label b1lab;
        private System.Windows.Forms.Label b2lab;
        private System.Windows.Forms.Label b3lab;
    }
}

