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

namespace PixLogic
{
    public partial class panUsers : UserControl
    {
        Database database;
        public panUsers()
        {
            InitializeComponent();
            if (MainWindow.START)
            {
                database = Helper.database;
                setTableUsers(database.GetAllUsers());
            }
        }

        public void setTableUsers(List<User> l)
        {
            List<User> list = l;
            dataGridUsers.Rows.Clear();
            foreach (var user in list)
            {
                dataGridUsers.Rows.Add(user.name,user.nickname,user.classe);
            }

            if (dataGridUsers.RowCount > 0)
            {
                dataGridUsers.FirstDisplayedScrollingRowIndex = 0;
                dataGridUsers.Refresh();
                dataGridUsers.CurrentCell = dataGridUsers.Rows[0].Cells[0];
                dataGridUsers.Rows[0].Selected = true;
            }

            setNewsUsers();
            //checkEnableButton();
        }
        private void setNewsUsers()
        {
            if (dataGridUsers.RowCount > 0)
            {
                //listBoxUsers.AllowDrop = true;
                valUserName.Text = dataGridUsers.CurrentRow.Cells[0].Value.ToString();
                valUserNickName.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
                valClass.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
                User user = database.GetUserByName(valUserName.Text);
                valMail.Text = user.mail;
                valTel.Text = user.phoneNumber;
                valUserId.Text = Convert.ToString(user.UserId);

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
                valUserNickName.Text = "-";
                pictureBoxUser.Image = null;
                valUserId.Text = "-";
            }

        }
        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxSearch.Text != "")
                setTableUsers(database.GetAllUsersByString(textBoxSearch.Text));
            else
                setTableUsers(database.GetAllUsers());
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
            WindowUser modif = new WindowUser(this, pictureBoxUser.Image, valUserName.Text,valUserNickName.Text,valMail.Text,valClass.Text,valTel.Text);
            modif.ShowDialog(this);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Helper.confirmation(Helper.DELETE))
            {
                database.DeleteUser(valUserName.Text);
                setTableUsers(database.GetAllUsers());
            }
        }
    }
}
