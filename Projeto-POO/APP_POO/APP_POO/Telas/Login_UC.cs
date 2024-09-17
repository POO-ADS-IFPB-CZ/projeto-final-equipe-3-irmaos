using APP_POO.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_POO.Telas
{
    public partial class Login_UC : UserControl
    {
        public event EventHandler RegisterClicked;
        public event EventHandler LoginAppClicked;

        public Login_UC()
        {
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            LoginAppClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
