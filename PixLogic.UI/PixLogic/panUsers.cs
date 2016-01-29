using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixLogic.DAL;
using System.Threading;

namespace PixLogic
{
    public partial class panUsers : UserControl
    {
        Database database;
        private List<User> listInTable;
        private WindowMail mail;
        private Thread thread;

        public panUsers()
        {
            InitializeComponent();
            if (MainWindow.START)
            {
                database = Helper.database;
                refresh();
            }
        }

        public void refresh()
        {
            listInTable = database.GetAllUsers();
            setTableUsers(listInTable);
            setComboBoxClasse();
        }

        private void setComboBoxClasse()
        {
            comboBoxClasse.Items.Clear();
            List<UserClass> list = database.GetAllUserClass();

            comboBoxClasse.Items.Add("");
            foreach (var classe in list)
            {
                if(!comboBoxClasse.Items.Contains(classe.name))
                    comboBoxClasse.Items.Add(classe.name);
            }
        }

        public void setTableUsers(List<User> l)
        {
            List<User> list = l;
            dataGridUsers.Rows.Clear();
            //dataGridUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            foreach (var user in list)
            {
                dataGridUsers.Rows.Add(user.UserId,user.name,user.nickname, user.mail, user.phoneNumber, user.userClass.name, user.credits);
            }

            if (dataGridUsers.RowCount > 0)
            {
                dataGridUsers.FirstDisplayedScrollingRowIndex = 0;
                dataGridUsers.Refresh();
                dataGridUsers.CurrentCell = dataGridUsers.Rows[0].Cells[0];
                dataGridUsers.Rows[0].Selected = true;
            }

            setNewsUsers();
            checkEnableButton();
        }
        private void setNewsUsers()
        {
            if (dataGridUsers.RowCount > 0)
            {
                //listBoxUsers.AllowDrop = true;
                valUserName.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
                valUserNickName.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
                valUserId.Text = dataGridUsers.CurrentRow.Cells[0].Value.ToString();
                
               User user = database.GetUserById(Convert.ToInt32(valUserId.Text));
                valMail.Text = user.mail;
                valTel.Text = user.phoneNumber;
                valClass.Text = (user.userClass.name);
                valUserCredits.Text = Convert.ToString(user.credits)+"/"+user.userClass.credits;

                Image img = database.ByteArrayToImage(user.image);
               Helper.putImageInBox(pictureBoxUser, img);
                valNbElements.Text = Convert.ToString(dataGridUsers.RowCount);
            }
            else
            {
                //listBoxUsers.AllowDrop = false;
                valUserName.Text = "-";
                valClass.Text = "-";
                valTel.Text = "-";
                valMail.Text = "-";
                valUserCredits.Text = "-";
                valUserNickName.Text = "-";
                pictureBoxUser.Image = null;
                valUserId.Text = "-";
                valNbElements.Text = "-";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WindowUser windowAdd = new WindowUser(this);
            windowAdd.ShowDialog(this);
        }

        private void dataGridUsers_Click(object sender, EventArgs e)
        {

            if (dataGridUsers.RowCount > 0)
                setNewsUsers();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (Helper.existReservationUser(true, Convert.ToInt32(valUserId.Text)) == false)
            {  
                WindowUser modif = new WindowUser(this, pictureBoxUser.Image, valUserName.Text, valUserNickName.Text, valMail.Text, valClass.Text, valTel.Text);
                modif.ShowDialog(this);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!Helper.existReservationUser(true, Convert.ToInt32(valUserId.Text)) && Helper.confirmation(Helper.DELETE))
            {
                    database.DeleteUser(Convert.ToInt32(valUserId.Text));
                    setTableUsers(database.GetAllUsers());
            }
        }
        private void checkEnableButton()
        {
            if (dataGridUsers.RowCount > 0)
            {
                buttonModify.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonModify.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableUsers(database.GetAllUsersByString(textBoxSearch.Text, listInTable));
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            comboBoxClasse.SelectedIndex = 0;
            setTableUsers(database.GetAllUsers());
        }

        private void pictureExport_Click(object sender, EventArgs e)
        {
            string title = "Liste des utilisateurs";
            WindowExport export = new WindowExport(dataGridUsers, title);
            export.ShowDialog();
        }

        private void pictureReserver_Click(object sender, EventArgs e)
        {
            if(dataGridUsers.RowCount == 0)
            {
                MessageBox.Show("Vous devez sélectionner un utilisateur.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idU = int.Parse(valUserId.Text);
                WindowReservationUser r = new WindowReservationUser(idU);
                r.ShowDialog();
            }
            
        }

        private void pictureReserver_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureReserver, "Créer réservation/emprunt.");
            pictureReserver.Cursor = Cursors.Hand;
        }

        public DataGridView getTable()
        {
            return dataGridUsers;
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            if(dataGridUsers.RowCount > 0)
            {
                if(valMail.Text.Equals(""))
                {
                    MessageBox.Show("Cet utilisateur n'a pas d'adresse e-mail.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(database.ExistMailConfig())
                {
                    thread = new Thread(new ThreadStart(openWindowMail));
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas envoyer de mail.\nVous devez préalablement configurer les paramètres d'envoi dans:\nOptions->Paramètres->Envoi email.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un utilisateur.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void openWindowMail()
        {
            int idU = int.Parse(valUserId.Text);
            User u = database.GetUserById(idU);
            mail = new WindowMail(u);
            mail.ShowDialog();
            
        }

        private void dataGridUsers_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridUsers.RowCount > 0)
                setNewsUsers();
        }

        private void buttonMailSent_Click(object sender, EventArgs e)
        {
            WindowMailsSent mailSent = new WindowMailsSent();
            mailSent.Show();
        }

        private void buttonReinitCredit_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(buttonReinitCredit, "Réinitialiser tous les crédits des utilisateurs.");
        }

        private void buttonReinitCredit_Click(object sender, EventArgs e)
        {
            if(dataGridUsers.RowCount > 0)
            {
                bool result = false;
                DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment réinitialiser les crédits de tous les utilisateurs aux crédits de bases ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                result = (resultBox == DialogResult.Yes) ? true : false;
                if(result)
                {
                    database.ResetAllUsersCredits();
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Il n'ya aucun utilisateur présent.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAjoutCredit_Click(object sender, EventArgs e)
        {
            if(dataGridUsers.RowCount > 0)
            {
                int idU = int.Parse(valUserId.Text);
                WindowAddCredit addCredit = new WindowAddCredit(idU, this);
                addCredit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxClasse.SelectedItem.ToString().Equals(""))
            {
                UserClass classe = database.GetUserClassByName(comboBoxClasse.SelectedItem.ToString());
                listInTable = getAllUserInClass(classe.UserClassId);
                setTableUsers(listInTable);
            }
            else
            {
                listInTable = database.GetAllUsers();
                setTableUsers(listInTable);
            }
        }

        private List<User> getAllUserInClass(int idClass)
        {
            var users = database.GetAllUsers().Where(u => u.userClass.UserClassId == idClass);
            return users.ToList();
        }
    }
}
