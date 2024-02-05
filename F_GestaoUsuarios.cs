using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Academia
{
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;

        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
