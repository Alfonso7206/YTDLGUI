namespace YTDLGUI
{
    partial class fmBinary
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label_Prog1 = new MaterialSkin.Controls.MaterialLabel();
            this.label_Prog2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 18);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "yt-dlp :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 104);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(112, 18);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "ffmpeg -ffprobe:";
            // 
            // label_Prog1
            // 
            this.label_Prog1.AutoSize = true;
            this.label_Prog1.BackColor = System.Drawing.Color.Transparent;
            this.label_Prog1.Depth = 0;
            this.label_Prog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Prog1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Prog1.Location = new System.Drawing.Point(141, 73);
            this.label_Prog1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_Prog1.Name = "label_Prog1";
            this.label_Prog1.Size = new System.Drawing.Size(46, 18);
            this.label_Prog1.TabIndex = 2;
            this.label_Prog1.Text = "[ null ]";
            // 
            // label_Prog2
            // 
            this.label_Prog2.AutoSize = true;
            this.label_Prog2.BackColor = System.Drawing.Color.Transparent;
            this.label_Prog2.Depth = 0;
            this.label_Prog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Prog2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Prog2.Location = new System.Drawing.Point(141, 104);
            this.label_Prog2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_Prog2.Name = "label_Prog2";
            this.label_Prog2.Size = new System.Drawing.Size(46, 18);
            this.label_Prog2.TabIndex = 3;
            this.label_Prog2.Text = "[ null ]";
            // 
            // fmBinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 137);
            this.Controls.Add(this.label_Prog2);
            this.Controls.Add(this.label_Prog1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBinary";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Binary";
            this.Load += new System.EventHandler(this.fmBinary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel label_Prog1;
        private MaterialSkin.Controls.MaterialLabel label_Prog2;
    }
}