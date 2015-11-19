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
    public partial class panReservation : UserControl
    {
        Database database;
        public panReservation()
        {
            InitializeComponent();
            if (MainWindow.START)
            {
                database = Helper.database;
                setTableReservations(database.GetAllReservations());
            }
        }
        public void setTableReservations(List<Reservation> l)
        {
            List<Reservation> list = l;
            dataGridReservations.Rows.Clear();
            foreach (var reser in list)
            {
                dataGridReservations.Rows.Add(reser.ReservationId, reser.User.name, reser.Item.Name);
            }

            if (dataGridReservations.RowCount > 0)
            {
                dataGridReservations.FirstDisplayedScrollingRowIndex = 0;
                dataGridReservations.Refresh();
                dataGridReservations.CurrentCell = dataGridReservations.Rows[0].Cells[0];
                dataGridReservations.Rows[0].Selected = true;
            }

            setNewsUsers();
            //checkEnableButton();
        }
        /*
        private void setNewsUsers()
        {
            if (dataGridReservations.RowCount > 0)
            {
                //listBoxUsers.AllowDrop = true;
                valUserName.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
                valUserNickName.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
                valReservationId.Text = dataGridUsers.CurrentRow.Cells[0].Value.ToString();
                User user = database.GetUserById(dataGridUsers.CurrentRow.Cells[0].Value.ToString());
                valMail.Text = user.mail;
                valTel.Text = user.phoneNumber;
                valClass.Text = user.classe;

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
        */
    }
}
