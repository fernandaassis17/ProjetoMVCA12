using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMVCA12.BLL;
using ProjetoMVCA12.DAL;
using ProjetoMVCA12.DTO;

namespace ProjetoMVCA12
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        tblClienteBLL objlogin = new tblClienteBLL();
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objcliente = new tblClienteDTO();
                objcliente.Email_cliente = txt_email.Text.Trim();
                objcliente.Senha_cliente = txt_senha.Text.Trim();
                this.Visible = false;
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(objcliente.Email_cliente, objcliente.Senha_cliente))
                {
                    MessageBox.Show("Cliente Localizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmDados dados = new FrmDados();
                    dados.ShowDialog();
                    this.Visible = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cliente Não Localizado", "Falho!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void lbl_Esquecisenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblClienteBLL bllCliente = new tblClienteBLL();
            string senha = bllCliente.RecuperarSenha(txt_email.Text.Trim());
            MessageBox.Show(senha, "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
