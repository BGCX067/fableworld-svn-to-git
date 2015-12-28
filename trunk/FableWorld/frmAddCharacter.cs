using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using DTL;

namespace FableWorld
{
    public partial class frmAddCharacter : Form
    {
        public frmAddCharacter()
        {
            InitializeComponent();
        }

        private void frmAddCharacter_Load(object sender, EventArgs e)
        {
            List<CharacterDTO> characters = CharacterDAC.GetCharactersNotInParty(ContextManager.Current.ActiveAccountID);

            if (characters.Count > 0)
                characterPanel1.Controls.Add(new CharacterInfoControl(characters[0]));
            if (characters.Count > 1)
                characterPanel2.Controls.Add(new CharacterInfoControl(characters[1]));
            if (characters.Count > 2)
                characterPanel3.Controls.Add(new CharacterInfoControl(characters[2]));
            if (characters.Count > 3)
                characterPanel4.Controls.Add(new CharacterInfoControl(characters[3]));
            if (characters.Count > 4)
                characterPanel5.Controls.Add(new CharacterInfoControl(characters[4]));
            if (characters.Count > 5)
                characterPanel6.Controls.Add(new CharacterInfoControl(characters[5]));
        }
    }
}
