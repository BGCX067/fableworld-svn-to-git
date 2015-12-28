namespace FableWorld
{
    partial class frmPartyManagement
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
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.characterPanel1 = new System.Windows.Forms.Panel();
            this.characterPanel2 = new System.Windows.Forms.Panel();
            this.characterPanel3 = new System.Windows.Forms.Panel();
            this.characterPanel4 = new System.Windows.Forms.Panel();
            this.characterPanel5 = new System.Windows.Forms.Panel();
            this.characterPanel6 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Location = new System.Drawing.Point(12, 41);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(157, 23);
            this.btnAddCharacter.TabIndex = 9;
            this.btnAddCharacter.Text = "&Add Character to Party";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Location = new System.Drawing.Point(12, 12);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(157, 23);
            this.btnCreateCharacter.TabIndex = 8;
            this.btnCreateCharacter.Text = "Create &New Character";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // characterPanel1
            // 
            this.characterPanel1.Location = new System.Drawing.Point(12, 83);
            this.characterPanel1.Name = "characterPanel1";
            this.characterPanel1.Size = new System.Drawing.Size(132, 147);
            this.characterPanel1.TabIndex = 16;
            // 
            // characterPanel2
            // 
            this.characterPanel2.Location = new System.Drawing.Point(206, 83);
            this.characterPanel2.Name = "characterPanel2";
            this.characterPanel2.Size = new System.Drawing.Size(132, 147);
            this.characterPanel2.TabIndex = 17;
            // 
            // characterPanel3
            // 
            this.characterPanel3.Location = new System.Drawing.Point(400, 83);
            this.characterPanel3.Name = "characterPanel3";
            this.characterPanel3.Size = new System.Drawing.Size(132, 147);
            this.characterPanel3.TabIndex = 17;
            // 
            // characterPanel4
            // 
            this.characterPanel4.Location = new System.Drawing.Point(12, 271);
            this.characterPanel4.Name = "characterPanel4";
            this.characterPanel4.Size = new System.Drawing.Size(132, 147);
            this.characterPanel4.TabIndex = 17;
            // 
            // characterPanel5
            // 
            this.characterPanel5.Location = new System.Drawing.Point(206, 271);
            this.characterPanel5.Name = "characterPanel5";
            this.characterPanel5.Size = new System.Drawing.Size(132, 147);
            this.characterPanel5.TabIndex = 17;
            // 
            // characterPanel6
            // 
            this.characterPanel6.Location = new System.Drawing.Point(400, 271);
            this.characterPanel6.Name = "characterPanel6";
            this.characterPanel6.Size = new System.Drawing.Size(132, 147);
            this.characterPanel6.TabIndex = 17;
            // 
            // frmPartyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 456);
            this.Controls.Add(this.characterPanel6);
            this.Controls.Add(this.characterPanel5);
            this.Controls.Add(this.characterPanel4);
            this.Controls.Add(this.characterPanel3);
            this.Controls.Add(this.characterPanel2);
            this.Controls.Add(this.characterPanel1);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.btnCreateCharacter);
            this.Name = "frmPartyManagement";
            this.Text = "Manage Party";
            this.Load += new System.EventHandler(this.frmPartyManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.Panel characterPanel1;
        private System.Windows.Forms.Panel characterPanel2;
        private System.Windows.Forms.Panel characterPanel3;
        private System.Windows.Forms.Panel characterPanel4;
        private System.Windows.Forms.Panel characterPanel5;
        private System.Windows.Forms.Panel characterPanel6;
    }
}