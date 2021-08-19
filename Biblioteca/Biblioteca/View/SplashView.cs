using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Biblioteca.View {
    public partial class SplashView : Form {
        public SplashView() {
            InitializeComponent();
        }

        private void novaJanela(Form form) {
            Rectangle bounds = this.Bounds;
            form.SetBounds(bounds.X, bounds.Y, form.Bounds.Width, form.Bounds.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
            //this.Hide();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (pbcarrega.Value < 100) {
                pbcarrega.Value = pbcarrega.Value + 2;
            }
            else {
                timer1.Enabled = false;
                this.Visible = false;
                LoginView login = new LoginView();
                novaJanela(login);
            }
        }
        private void SplashView_Load(object sender, EventArgs e) {
            
        }
    }
}

