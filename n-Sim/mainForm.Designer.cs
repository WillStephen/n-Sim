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
            this.xlab = new System.Windows.Forms.Label();
            this.ylab = new System.Windows.Forms.Label();
            this.ltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frameUpdater
            // 
            this.frameUpdater.Enabled = true;
            this.frameUpdater.Interval = 33;
            this.frameUpdater.Tick += new System.EventHandler(this.frameUpdater_Tick);
            // 
            // xlab
            // 
            this.xlab.AutoSize = true;
            this.xlab.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlab.ForeColor = System.Drawing.Color.White;
            this.xlab.Location = new System.Drawing.Point(13, 13);
            this.xlab.Name = "xlab";
            this.xlab.Size = new System.Drawing.Size(28, 18);
            this.xlab.TabIndex = 0;
            this.xlab.Text = "x:";
            // 
            // ylab
            // 
            this.ylab.AutoSize = true;
            this.ylab.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ylab.ForeColor = System.Drawing.Color.White;
            this.ylab.Location = new System.Drawing.Point(13, 31);
            this.ylab.Name = "ylab";
            this.ylab.Size = new System.Drawing.Size(28, 18);
            this.ylab.TabIndex = 1;
            this.ylab.Text = "y:";
            // 
            // ltotal
            // 
            this.ltotal.AutoSize = true;
            this.ltotal.BackColor = System.Drawing.Color.Black;
            this.ltotal.ForeColor = System.Drawing.Color.White;
            this.ltotal.Location = new System.Drawing.Point(16, 53);
            this.ltotal.Name = "ltotal";
            this.ltotal.Size = new System.Drawing.Size(35, 13);
            this.ltotal.TabIndex = 2;
            this.ltotal.Text = "label1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(699, 587);
            this.Controls.Add(this.ltotal);
            this.Controls.Add(this.ylab);
            this.Controls.Add(this.xlab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "n-Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer frameUpdater;
        private System.Windows.Forms.Label xlab;
        private System.Windows.Forms.Label ylab;
        private System.Windows.Forms.Label ltotal;
    }
}

