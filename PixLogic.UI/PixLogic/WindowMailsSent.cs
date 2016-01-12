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
    public partial class WindowMailsSent : Form
    {
        private Database database = Helper.database;
        private Dictionary<int, Mail> listMails;

        public WindowMailsSent()
        {
            InitializeComponent();
            listMails = new Dictionary<int, Mail>();
            setTableUserMail(database.GetAllMails());
        }

        private void setTableUserMail(List<Mail> m)
        {
            List<Mail> mails = m;
            dataGridUsersMail.Rows.Clear();

            foreach (Mail mail in mails)
            {
                listMails.Add(mail.MailId, mail);
                dataGridUsersMail.Rows.Add(mail.MailId, mail.nameUser, mail.nicknameUser, mail.date.Date.ToString());
            }

            if (dataGridUsersMail.RowCount > 0)
            {
                dataGridUsersMail.FirstDisplayedScrollingRowIndex = 0;
                dataGridUsersMail.Refresh();
                dataGridUsersMail.CurrentCell = dataGridUsersMail.Rows[0].Cells[1];
                dataGridUsersMail.Rows[0].Selected = true;
            }

            setNewsUsersMail();
        }

        private void setNewsUsersMail()
        {
            if (dataGridUsersMail.RowCount > 0)
            {
                int id = int.Parse(dataGridUsersMail.CurrentRow.Cells[0].Value.ToString());
                Mail mail = getMailById(id);

                valNom.Text = mail.nameUser;
                valPrenom.Text = mail.nicknameUser;
                valDate.Text = mail.date.ToString("F");
                valMail.Text = mail.mailUser;
                valSujet.Text = mail.subject;
                valMessage.Text = mail.text;
            }
            else
            {
                valNom.Text = "-";
                valPrenom.Text = "-";
                valDate.Text = "-";
                valMail.Text = "-";
                valSujet.Text = "-";
                valMessage.Text = "-";
            }
        }

        private Mail getMailById(int id)
        {
            foreach(KeyValuePair<int, Mail> value in listMails)
            {
                if(value.Key == id)
                {
                    return value.Value;
                }
            }
            return new Mail();
        }
        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //setTableUserMail(database.GetAllUsersByString(textBoxSearch.Text));
        }

        private void dataGridUsersMail_Click(object sender, EventArgs e)
        {
            if (dataGridUsersMail.RowCount > 0)
                setNewsUsersMail();
        }

        private void dataGridUsersMail_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridUsersMail.RowCount > 0)
                setNewsUsersMail();
        }
    }
}
