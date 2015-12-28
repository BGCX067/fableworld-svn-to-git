namespace FableWorld
{
    partial class CharacterInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterInfoControl));
            this.pbCharacter1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCharacter1
            // 
            this.pbCharacter1.BackColor = System.Drawing.Color.Black;
            this.pbCharacter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCharacter1.Image = ((System.Drawing.Image)(resources.GetObject("pbCharacter1.Image")));
            this.pbCharacter1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCharacter1.InitialImage")));
            this.pbCharacter1.Location = new System.Drawing.Point(15, 16);
            this.pbCharacter1.Name = "pbCharacter1";
            this.pbCharacter1.Size = new System.Drawing.Size(100, 82);
            this.pbCharacter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter1.TabIndex = 11;
            this.pbCharacter1.TabStop = false;
            this.pbCharacter1.Click += new System.EventHandler(this.pbCharacter1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Level:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(54, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "<name>";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(54, 114);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(41, 13);
            this.lblLevel.TabIndex = 15;
            this.lblLevel.Text = "<level>";
            // 
            // CharacterInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCharacter1);
            this.Name = "CharacterInfoControl";
            this.Size = new System.Drawing.Size(132, 147);
            this.Load += new System.EventHandler(this.CharacterInfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharacter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLevel;
    }
}
