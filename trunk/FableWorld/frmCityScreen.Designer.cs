namespace FableWorld
{
    partial class frmCityScreen
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
            this.btnManageParty = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVisitShopkeeper = new System.Windows.Forms.Button();
            this.btnPrayAtTemple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageParty
            // 
            this.btnManageParty.Location = new System.Drawing.Point(12, 12);
            this.btnManageParty.Name = "btnManageParty";
            this.btnManageParty.Size = new System.Drawing.Size(146, 23);
            this.btnManageParty.TabIndex = 0;
            this.btnManageParty.Text = "&Party Management";
            this.btnManageParty.UseVisualStyleBackColor = true;
            this.btnManageParty.Click += new System.EventHandler(this.btnManageParty_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Leave Town";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVisitShopkeeper
            // 
            this.btnVisitShopkeeper.Location = new System.Drawing.Point(12, 41);
            this.btnVisitShopkeeper.Name = "btnVisitShopkeeper";
            this.btnVisitShopkeeper.Size = new System.Drawing.Size(146, 23);
            this.btnVisitShopkeeper.TabIndex = 2;
            this.btnVisitShopkeeper.Text = "&Visit Shopkeeper";
            this.btnVisitShopkeeper.UseVisualStyleBackColor = true;
            // 
            // btnPrayAtTemple
            // 
            this.btnPrayAtTemple.Location = new System.Drawing.Point(12, 70);
            this.btnPrayAtTemple.Name = "btnPrayAtTemple";
            this.btnPrayAtTemple.Size = new System.Drawing.Size(146, 23);
            this.btnPrayAtTemple.TabIndex = 3;
            this.btnPrayAtTemple.Text = "Pray at &Temple";
            this.btnPrayAtTemple.UseVisualStyleBackColor = true;
            // 
            // frmCityScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FableWorld.Properties.Resources.phantasie_iii_02;
            this.ClientSize = new System.Drawing.Size(320, 228);
            this.Controls.Add(this.btnPrayAtTemple);
            this.Controls.Add(this.btnVisitShopkeeper);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManageParty);
            this.Name = "frmCityScreen";
            this.Text = "<City>";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageParty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVisitShopkeeper;
        private System.Windows.Forms.Button btnPrayAtTemple;

    }
}