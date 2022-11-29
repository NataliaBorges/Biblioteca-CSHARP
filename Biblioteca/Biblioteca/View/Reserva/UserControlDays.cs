using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.View.Reserva
{
    public partial class UserControlDays : UserControl
    {
        Nullable<DateTime> data = null;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void Dia(int num)
        {
            lblDia.Text = num+"";
        }

        public void possuiReservaNoDia(DateTime data)
        {
            this.data = data;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1A0D");
            lblDia.ForeColor = Color.White;
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            if(data.HasValue)
            {
                ReservaBuscarDiaView reservaBuscarDiaView = new ReservaBuscarDiaView(data.Value);
                NovaJanela.novaJanela(reservaBuscarDiaView, Bounds);
            }
        }
    }
}
