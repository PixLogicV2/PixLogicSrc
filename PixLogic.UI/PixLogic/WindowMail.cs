using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixLogic.DAL;

namespace PixLogic
{
    public partial class WindowMail : Form
    {
        private int idReservation;
        private Database database = Helper.database;

        public WindowMail(int idReservation)
        {
            InitializeComponent();
            this.idReservation = idReservation;
            setNewsUser();
        }

        private void setNewsUser()
        {
            Reservation r = database.GetReservationById(idReservation);
            valUserName.Text = r.user.name + " " + r.user.nickname;
            valMail.Text = r.user.mail;
            valTel.Text = r.user.phoneNumber;
            valClass.Text = r.user.userClass.name;

            Helper.putImageInBox(pictureBoxUser, database.ByteArrayToImage(r.user.image));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
