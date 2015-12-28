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
    public partial class frmCreateCharacter : Form
    {
        public frmCreateCharacter()
        {
            InitializeComponent();
        }

        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            CharacterDTO character = new CharacterDTO(tbCharacterName.Text, Convert.ToInt32(cmbClass.SelectedValue), Convert.ToInt32(cmbRace.SelectedValue), rbMale.Checked);
            CharacterDAC.CreateCharacter(character, ContextManager.Current.ActiveAccountID);
        }

        private void frmCreateCharacter_Load(object sender, EventArgs e)
        {
            List<RaceDTO> races = RaceDAC.GetRaces();
            cmbRace.DataSource = races;
            cmbRace.DisplayMember = "Title";
            cmbRace.ValueMember = "ID";

            List<ClassDTO> classes = ClassDAC.GetClasses();
            cmbClass.DataSource = classes;
            cmbClass.DisplayMember = "Title";
            cmbClass.ValueMember = "ID";
        }
    }
}
