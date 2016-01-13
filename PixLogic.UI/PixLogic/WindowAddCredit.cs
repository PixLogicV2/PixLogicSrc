using PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixLogic
{
    public partial class WindowAddCredit : Form
    {
        private User user;
        private Database database = Helper.database;
        private panUsers panU;

        public WindowAddCredit(int id, panUsers u)
        {
            InitializeComponent();
            user = database.GetUserById(id);
            panU = u;
            valNomPrenom.Text = user.name + " " + user.nickname;
            valCredit.Text = Convert.ToString(user.credits);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            if(!Helper.fieldsAreEmpty(true, valCreditToAdd.Text) && Helper.AreNumbers(true, valCreditToAdd.Text))
            {
                int creditAjout = int.Parse(valCreditToAdd.Text);
                int creditTotal = user.credits + creditAjout;
                if(creditTotal > user.userClass.credits)
                {
                    MessageBox.Show("Avec ce crédit ajouté, le crédit total de l'utilisateur sera supérieur au crédit de sa classe qui est: "+user.userClass.credits, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool result = false;
                    DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment créditer cet utilisateur ?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    result = (resultBox == DialogResult.Yes) ? true : false;
                    if (result)
                    {
                        database.AddCredits(user.UserId, creditAjout);
                        panU.refresh();
                        this.Close();
                    }
                    
                }
            }
        }
    }
}
