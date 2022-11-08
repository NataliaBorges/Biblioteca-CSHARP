﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Reserva
{
    public partial class ReservaMesView : Form
    {
        int month, year;
        public ReservaMesView()
        {
            InitializeComponent();
        }

        private void ReservaVisualizarView_Load(object sender, EventArgs e)
        {
            this.menuControl1.setForm(this);
            this.menuControl1.setPanel(pnltotal);

            this.head1.setForm(this);
            this.head1.setPaddind(this.Padding);

            DisplaDays();
        }
        private void ReservaVisualizarView_Activated(object sender, EventArgs e)
        {
            
        }
        private void DisplaDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            String nomeUpper = nomeMes.ToUpper();
            lbldata.Text = nomeUpper + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int diaSemana = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlBlank ublank = new UserControlBlank();
                dayContainer.Controls.Add(ublank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Dia(i);
                dayContainer.Controls.Add(ucdays);

            }
        }

        private void BtnProximo(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            String nomeUpper = nomeMes.ToUpper();
            lbldata.Text = nomeUpper + " " + year;

            //lbldata.Font = new Font("Book Antiqua", this.lbldata.Font.Size);

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int diaSemana = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlBlank ublank = new UserControlBlank();
                dayContainer.Controls.Add(ublank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Dia(i);
                dayContainer.Controls.Add(ucdays);

            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            String nomeUpper = nomeMes.ToUpper();
            lbldata.Text = nomeUpper + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int diaSemana = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaSemana; i++)
            {
                UserControlBlank ublank = new UserControlBlank();
                dayContainer.Controls.Add(ublank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Dia(i);
                dayContainer.Controls.Add(ucdays);

            }
        }
    }
}
