﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixLogic.DAL;
using System.Net.Mail;
using System.Net;

namespace PixLogic
{
    public partial class WindowMail : Form
    {
        private int idReservation;
        private Database database = Helper.database;
        private MailConfig config;
        private string name, prenom;

        public WindowMail(int idReservation)
        {
            InitializeComponent();
            this.idReservation = idReservation;
            config = database.GetMailConfig();
            this.StartPosition = FormStartPosition.CenterScreen;
            setNewsUser();
        }
        public WindowMail(User user)
        {
            InitializeComponent();
            config = database.GetMailConfig();
            this.StartPosition = FormStartPosition.CenterScreen;
            valUserName.Text = user.name + " " + user.nickname;
            name = user.name; prenom = user.nickname;
            valMail.Text = user.mail;
            valTel.Text = user.phoneNumber;
            valClass.Text = user.userClass.name;

            Helper.putImageInBox(pictureBoxUser, database.ByteArrayToImage(user.image));
        }


        private void encours()
        {
            labelInfo.ForeColor = Color.Blue;
            labelInfo.Text = "Envoi en cours...";
        }
        private void success()
        {
            labelInfo.ForeColor = Color.Green;
            labelInfo.Text = "Envoi en réussi!";
        }
        private void echec()
        {
            labelInfo.ForeColor = Color.Red;
            labelInfo.Text = "Echec de l'envoi.";
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

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(!Helper.fieldsAreEmpty(true, valSubject.Text, valMessage.Text))
            {
                encours();
                try
                {
                    MailMessage mail = new MailMessage(config.email, valMail.Text, valSubject.Text, valMessage.Text);
                    SmtpClient client = new SmtpClient(config.serveurStmp);
                    client.Port = config.port;
                    client.Credentials = new NetworkCredential(config.email, config.mdp);
                    client.EnableSsl = true;
                    this.Cursor = Cursors.WaitCursor;
                
                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                    echec();
                    this.TopMost = true;
                    this.Activate();
                    this.TopMost = false;
                    return;
                }
                this.Cursor = Cursors.Default;
                success();
                database.AddMail(name, prenom, valMail.Text, valMessage.Text, DateTime.Now, valSubject.Text);
                valSubject.ReadOnly = true;
                valMessage.ReadOnly = true;
                buttonCancel.Enabled = false;
                buttonSend.Enabled = false;
                this.TopMost = true;
                this.Activate();
                this.TopMost = false;
            }
            
        }
    }
}
