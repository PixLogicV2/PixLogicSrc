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
    public partial class WindowSetReservation : Form
    {
        private int idReservation;
        private Database database = Helper.database;

        public WindowSetReservation(int id)
        {
            InitializeComponent();
            idReservation = id;
            setInfos();
        }

        private void setInfos()
        {
            Reservation reserv = database.GetReservationById(idReservation);

            valNomReservable.Text = reserv.reservable.name;
            valType.Text = reserv.isPack ? Helper.PACK : Helper.ITEM;
            valDateFin.Text = ((DateTime)reserv.beginDateReservation).ToString("D");
            valDateDebut.Text = ((DateTime)reserv.endDateReservation).ToString("D");
            if(!reserv.isPack)
            {
                Helper.putImageInBox(pictureBoxItem, database.ByteArrayToImage(((Item)reserv.reservable).image));
            }
        }
        
        private void setTableDateReservation()
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            DateTime debut = DateTime.Parse(dateTimeBegin.Value.ToString());
            DateTime fin = DateTime.Parse(dateTimeEnd.Value.ToString());

            if (Helper.beginBeforeEndDate(true, debut, fin))
            {

            }
        }
    }
}
