using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTL;
using System.Resources;

namespace FableWorld
{
    public partial class CharacterInfoControl : UserControl
    {

        public CharacterInfoControl(CharacterDTO character)
        {
            InitializeComponent();
            lblName.Text = character.Name;
            ResourceManager resourceManager = new ResourceManager ("FableWorld.Resources", GetType().Assembly);
            Bitmap image = (Bitmap)resourceManager.GetObject ("Warrior");


            pbCharacter1.Image = image;
        }

        private void pbCharacter1_Click(object sender, EventArgs e)
        {
            new frmAddCharacter().ShowDialog();
        }

        private void CharacterInfoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
