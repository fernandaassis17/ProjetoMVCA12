using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMVCA12.BLL;
using ProjetoMVCA12.DAL;
using ProjetoMVCA12.DTO;

namespace ProjetoMVCA12
{
    
    class ConsultarBeneficio
    {
        private string nome_cliente, sobrenome_cliente, email_cliente, cpf_cliente, senha_cliente, nome_mae;
       
        public string Nome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório");
                }
            }


            get
            {
                return this.nome_cliente;
            }

        }

     
        public string Sobrenome_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.sobrenome_cliente = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório");
                }
            }


            get
            {
                return this.sobrenome_cliente;
            }

        }
        public string Cpf_cliente
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf_cliente = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório");
                }
            }


            get
            {
                return this.cpf_cliente;
            }

        }

        public string Nome_mae
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("O campo nome da mãe é obrigatório");
                }
            }


            get
            {
                return this.nome_mae;
            }

        }

    }
}
