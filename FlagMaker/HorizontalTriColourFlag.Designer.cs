namespace FlagMaker
{
    partial class HorizontalTriColourFlag
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
            this.hPreviewBox1of3P = new System.Windows.Forms.Label();
            this.hPreviewBox2of3P = new System.Windows.Forms.Label();
            this.hPreviewBox3of3P = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hPreviewBox1of3P
            // 
            this.hPreviewBox1of3P.AutoSize = true;
            this.hPreviewBox1of3P.BackColor = System.Drawing.Color.Transparent;
            this.hPreviewBox1of3P.Location = new System.Drawing.Point(0, 0);
            this.hPreviewBox1of3P.MinimumSize = new System.Drawing.Size(1060, 200);
            this.hPreviewBox1of3P.Name = "hPreviewBox1of3P";
            this.hPreviewBox1of3P.Size = new System.Drawing.Size(1060, 200);
            this.hPreviewBox1of3P.TabIndex = 0;
            this.hPreviewBox1of3P.Text = " ";
            // 
            // hPreviewBox2of3P
            // 
            this.hPreviewBox2of3P.AutoSize = true;
            this.hPreviewBox2of3P.BackColor = System.Drawing.Color.Transparent;
            this.hPreviewBox2of3P.Location = new System.Drawing.Point(-1, 200);
            this.hPreviewBox2of3P.MinimumSize = new System.Drawing.Size(1060, 200);
            this.hPreviewBox2of3P.Name = "hPreviewBox2of3P";
            this.hPreviewBox2of3P.Size = new System.Drawing.Size(1060, 200);
            this.hPreviewBox2of3P.TabIndex = 1;
            // 
            // hPreviewBox3of3P
            // 
            this.hPreviewBox3of3P.AutoSize = true;
            this.hPreviewBox3of3P.BackColor = System.Drawing.Color.Transparent;
            this.hPreviewBox3of3P.Location = new System.Drawing.Point(0, 400);
            this.hPreviewBox3of3P.MinimumSize = new System.Drawing.Size(1060, 200);
            this.hPreviewBox3of3P.Name = "hPreviewBox3of3P";
            this.hPreviewBox3of3P.Size = new System.Drawing.Size(1060, 200);
            this.hPreviewBox3of3P.TabIndex = 2;
            // 
            // HorizontalTriColourFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1058, 598);
            this.Controls.Add(this.hPreviewBox3of3P);
            this.Controls.Add(this.hPreviewBox2of3P);
            this.Controls.Add(this.hPreviewBox1of3P);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "HorizontalTriColourFlag";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Horizontal Tri Colour Flag - Preview";
            this.Load += new System.EventHandler(this.HorizontalTriColourFlag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hPreviewBox1of3P;
        private System.Windows.Forms.Label hPreviewBox2of3P;
        private System.Windows.Forms.Label hPreviewBox3of3P;
    }
}