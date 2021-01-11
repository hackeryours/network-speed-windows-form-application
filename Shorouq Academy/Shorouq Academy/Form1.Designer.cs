namespace Shorouq_Academy
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
            this.closebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.speedtxt = new System.Windows.Forms.Label();
            this.umtxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebtn.BackgroundImage")));
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Roboto Black", 9.25F, System.Drawing.FontStyle.Bold);
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.closebtn.Location = new System.Drawing.Point(0, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(64, 63);
            this.closebtn.TabIndex = 0;
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 147);
            this.panel1.TabIndex = 1;
            // 
            // speedtxt
            // 
            this.speedtxt.AutoSize = true;
            this.speedtxt.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.speedtxt.Location = new System.Drawing.Point(-5, 241);
            this.speedtxt.Name = "speedtxt";
            this.speedtxt.Size = new System.Drawing.Size(422, 111);
            this.speedtxt.TabIndex = 2;
            this.speedtxt.Text = "Loading";
            this.speedtxt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // umtxt
            // 
            this.umtxt.AutoSize = true;
            this.umtxt.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.umtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.umtxt.Location = new System.Drawing.Point(252, 171);
            this.umtxt.Name = "umtxt";
            this.umtxt.Size = new System.Drawing.Size(144, 56);
            this.umtxt.TabIndex = 4;
            this.umtxt.Text = "Kbps";
            this.umtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 440);
            this.Controls.Add(this.umtxt);
            this.Controls.Add(this.speedtxt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label speedtxt;
        private System.Windows.Forms.Label umtxt;
    }
}

