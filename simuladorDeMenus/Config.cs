﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simuladorDeMenus
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show(
                "Você realmente deseja voltar ao Menu Inicial?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao == DialogResult.Yes)
            {
                Form1 inicio = new Form1();
                inicio.Show();

                this.Close();
            }
        }

        private void listCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cor = listCor.SelectedIndex;
            
            switch(cor) 
            {
                case 0:
                    this.BackColor = Color.Yellow;
                    lblTitulo.ForeColor = Color.Black;
                    lblFundo.ForeColor = Color.Black;
                    lblImagem.ForeColor = Color.Black;
                    break;
                case 1:
                    this.BackColor = Color.White;
                    lblTitulo.ForeColor = Color.Black;
                    lblFundo.ForeColor = Color.Black;
                    lblImagem.ForeColor = Color.Black;
                    break;
                case 2:
                    this.BackColor = Color.Orange;
                    lblTitulo.ForeColor = Color.White;
                    lblFundo.ForeColor = Color.White;
                    lblImagem.ForeColor = Color.White;
                    break;
                case 3:
                    this.BackColor = Color.Purple;
                    lblTitulo.ForeColor = Color.White;
                    lblFundo.ForeColor = Color.White;
                    lblImagem.ForeColor = Color.White;
                    break;
                case 4:
                    this.BackColor = Color.LightSalmon;
                    break;
                case 5:
                    this.BackColor = Color.DarkRed;
                    lblTitulo.ForeColor = Color.White;
                    lblFundo.ForeColor = Color.White;
                    lblImagem.ForeColor = Color.White;
                    break;
            }
        }

        private void listImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int imagem = listImage.SelectedIndex;

            switch (imagem)
            {
                case 0:
                    picBox.Image = Properties.Resources.everynyan;
                    break;
                case 1:
                    picBox.Image = Properties.Resources.giornokujo;
                    break;
                case 2:
                    picBox.Image = Properties.Resources.osaka;
                    break;
                case 3:
                    picBox.Image = Properties.Resources.quieres;
                    break;
                case 4:
                    picBox.Image = Properties.Resources.toro2;
                    break;
            }
        }
    }
}
