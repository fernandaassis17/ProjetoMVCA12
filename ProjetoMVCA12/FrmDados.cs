using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using ProjetoMVCA12.BLL;
using ProjetoMVCA12.DAL;
using ProjetoMVCA12.DTO;

namespace ProjetoMVCA12
{
    public partial class FrmDados : Form
    {
        public FrmDados()
        {
            InitializeComponent();
        }

        

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objcliente = new tblClienteDTO();
                objcliente.Cpf_cliente = txt_CpfA12.Text.Trim();
                objcliente.Nome_cliente = txt_nomeA12.Text.Trim();
                objcliente.Nome_mae = txt_NomeMaeA12.Text.Trim();
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.VerificarDados(objcliente.Nome_cliente, objcliente.Cpf_cliente, objcliente.Nome_mae))
                {
                    MessageBox.Show("Beneficiário Localizado no Banco de dados.", "Processo em Análise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Beneficiário Não Localizado no Banco de dados.", "Benefício Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        


    }
}
