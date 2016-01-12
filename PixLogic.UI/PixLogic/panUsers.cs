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
            setTableUsers(database.GetAllUsers());
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
            if (Helper.confirmation(Helper.DELETE) && Helper.existReservationUser(true, Convert.ToInt32(valUserId.Text)) == false)
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
            setTableUsers(database.GetAllUsersByString(textBoxSearch.Text));
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
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
        
    }
}
