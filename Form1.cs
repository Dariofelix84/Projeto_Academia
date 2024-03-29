﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_nomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_acesso_Click(object sender, EventArgs e)
        {

        }

        private void pb_ledLogado_Click(object sender, EventArgs e)
        {


        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();


        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.img_red2;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel == 3)
                {
                    //PECEDIMENTOS
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (Globais.logado)
                {
                    if (Globais.nivel >= 2)
                    {
                        F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                        f_NovoUsuario.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Acesso não permitido");
                    }
                }
                else
                {
                    MessageBox.Show("É necessário ter um usuário logado");
                }
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (Globais.logado)
                {
                    if (Globais.nivel >= 2)
                    {
                        F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                        f_GestaoUsuarios.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Acesso não permitido");
                    }
                }
                else
                {
                    MessageBox.Show("É necessário ter um usuário logado");
                }
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (Globais.logado)
                {
                    //PORCEDIMENTOS
                }
                else
                {
                    MessageBox.Show("É necessário ter um usuário logado");
                }
            }
        }

        private void pb_ledLogado_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}