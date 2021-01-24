namespace Python_Hub
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Get_Started = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(84, 139);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(467, 34);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Welcome to the World of Python!";
            // 
            // Get_Started
            // 
            this.Get_Started.ActiveBorderThickness = 1;
            this.Get_Started.ActiveCornerRadius = 20;
            this.Get_Started.ActiveFillColor = System.Drawing.Color.DarkOrchid;
            this.Get_Started.ActiveForecolor = System.Drawing.Color.Ivory;
            this.Get_Started.ActiveLineColor = System.Drawing.Color.DarkOrchid;
            this.Get_Started.BackColor = System.Drawing.Color.Ivory;
            this.Get_Started.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Get_Started.BackgroundImage")));
            this.Get_Started.ButtonText = "Get Started";
            this.Get_Started.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Get_Started.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Started.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Get_Started.IdleBorderThickness = 1;
            this.Get_Started.IdleCornerRadius = 15;
            this.Get_Started.IdleFillColor = System.Drawing.Color.Ivory;
            this.Get_Started.IdleForecolor = System.Drawing.Color.DarkOrchid;
            this.Get_Started.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.Get_Started.Location = new System.Drawing.Point(219, 197);
            this.Get_Started.Margin = new System.Windows.Forms.Padding(5);
            this.Get_Started.Name = "Get_Started";
            this.Get_Started.Size = new System.Drawing.Size(181, 41);
            this.Get_Started.TabIndex = 1;
            this.Get_Started.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Get_Started.Click += new System.EventHandler(this.Get_Started_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(649, 400);
            this.Controls.Add(this.Get_Started);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Get_Started;
    }
}

