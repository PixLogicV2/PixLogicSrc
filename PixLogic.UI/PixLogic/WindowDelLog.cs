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
    public partial class WindowDelLog : Form
    {
        private int idLog;
        private panLog pan;
        private Database database = Helper.database;

        public WindowDelLog(int id, panLog pLog)
        {
            InitializeComponent();
            idLog = id;
            pan = pLog;
            initialize();
            
        }

        private void initialize()
        {
            radioById.Checked = true;
            valId.ReadOnly = true;
            valId.Text = Convert.ToString(idLog);
            //---

            valNomReservable.Enabled = false;
            valNomReservable.Text = "nom du matériel ou pack...";
            //--

            dateTimeDebut.Enabled = false;
            dateTimeFin.Enabled = false;
        }

        private void selectById()
        {
            valNomReservable.Enabled = false;

            dateTimeFin.Enabled = false;
            dateTimeDebut.Enabled = false;
        }

        private void selectByName()
        {
            valNomReservable.Enabled = true;

            dateTimeFin.Enabled = false;
            dateTimeDebut.Enabled = false;

        }

        private void selectByDate()
        {
            valNomReservable.Enabled = false;

            dateTimeDebut.Enabled = true;
            dateTimeFin.Enabled = true;
        }

        private void radioById_CheckedChanged(object sender, EventArgs e)
        {
            selectById();
        }

        private void radioByName_CheckedChanged(object sender, EventArgs e)
        {
            selectByName();
        }

        private void radioBetween_CheckedChanged(object sender, EventArgs e)
        {
            selectByDate();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment supprimer ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            if(result)
            {
                if (radioById.Checked)
                {
                    database.DeleteLogById(idLog);
                    pan.refresh();
                    this.Close();
                }
                else if (radioByName.Checked)
                {
                    if (NameReservableExist(valNomReservable.Text))
                    {
                        database.DeleteLogByReservableName(valNomReservable.Text);
                        pan.refresh();
                        this.Close();
                    }

                }
                else if (radioBetween.Checked)
                {
                    if (Helper.beginBeforeEndDate(true, dateTimeDebut.Value.Date, dateTimeFin.Value.Date))
                    {
                        database.DeleteLogByDate(dateTimeDebut.Value.Date, dateTimeFin.Value.Date);
                        pan.refresh();
                        this.Close();
                    }

                }
            }
            
        }

        private bool NameReservableExist(string name)
        {
            List<Log> logs = database.GetAllLogs();
            foreach(Log log in logs)
            {
                if(log.reservableName.Equals(name))
                {
                    return true;
                }
            }
            MessageBox.Show("Le nom du pack ou du matériel renseigné n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
