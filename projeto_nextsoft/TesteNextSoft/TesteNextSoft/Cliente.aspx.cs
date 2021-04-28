using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace TesteNextSoft
{
    public partial class Cliente : System.Web.UI.Page    {    
       
        //Instancia dois metodos
        ClienteService clienteService = new ClienteService();

        ClienteValidacaoCpf clienteCpf = new ClienteValidacaoCpf(); 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            txtNome.Focus();
            
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Executa o metodo cadastrar
            cadastrar();
        }

        
        public void cadastrar()
        {
            //Verifica se os campos estão vazios
            if ((string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCpf.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTel.Text) ||
                string.IsNullOrEmpty(txtTipo.Text) || string.IsNullOrEmpty(txtLog.Text) || string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtNome.Text) ||
                string.IsNullOrEmpty(dropEstado.Text) || string.IsNullOrEmpty(dropCidade.Text))
               )
            {                
                lblMensagem.Visible = true;
                lblMensagem.Text =  "Favor preencher todos os campos necessários";
                txtNome.Focus();
                return;
            }
            else
            {
                //Verifica se o CPF é válido
                if (clienteCpf.ValidaCPF(txtCpf.Text))
                {
                    //Verifica se o telefone possui menos de 10 caracteres e se o campo esta preenchido com um número
                    if ((txtTel.Text.Length < 10) && (!Regex.IsMatch(txtTel.Text, @"^[0-9]+$")))
                    {
                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Número de Tefone incorreto";                        
                    }
                    else
                    {
                        //Verifica se o CPF já existe no banco
                        if (clienteService.validarExistCPF(txtCpf.Text))
                        {
                            //Executa dois metodos
                            clienteService.cadastrarCliente(txtNome.Text, txtCpf.Text, txtEmail.Text, txtTel.Text);
                            clienteService.cadastrarEndereco(txtCpf.Text, txtTipo.Text, txtLog.Text, txtNum.Text, txtComp.Text, txtBairro.Text, dropEstado.Text, dropCidade.Text);

                            //Limpa os campos e informa o usuário que cadastro foi realizado com sucesso
                            lblMensagem.Visible = true;
                            lblMensagem.Text = "Cadastro Realizado com Sucesso";                                                  
                            txtBairro.Text = string.Empty;
                            dropCidade.Text = string.Empty;
                            txtComp.Text = string.Empty;
                            dropEstado.Text = string.Empty;
                            txtLog.Text = string.Empty;
                            txtNum.Text = string.Empty;
                            txtTipo.Text = string.Empty;
                            txtBairro.Text = string.Empty;
                            dropCidade.Text = string.Empty;                           
                            btnCadastrar.Visible = false;
                            btnIncluirEndAd.Visible = true;
                            btnCliente.Visible = true;
                            
                        }
                        else
                        {
                            //Informa o usuário que o CPF já existe
                            lblMensagem.Visible = true;
                            lblMensagem.Text = "CPF já existe!";                            
                        }

                    }
                }
                else
                {
                    //Informa o usuário que o CPF é inválido
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "CPF Inválido!";                    
                }
            }

        }

        

        protected void btnIncluirEndAd_Click(object sender, EventArgs e)
        {
            //Verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(txtCpf.Text) || string.IsNullOrEmpty(txtTipo.Text) || string.IsNullOrEmpty(txtLog.Text)
                || string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(dropEstado.Text)
                || string.IsNullOrEmpty(dropCidade.Text))
            {
                MessageBox.Show("Favor preencher todos os campos necessários");
            }
            else
            {
                //Se os campos estiverem preenchidos executa o cadastrarEndereco
                clienteService.cadastrarEndereco(txtCpf.Text, txtTipo.Text, txtLog.Text, txtNum.Text, txtComp.Text, txtBairro.Text, dropEstado.Text, dropCidade.Text);

                //limpa os campos e informa que o endereço foi cadastrado com sucesso
                txtTipo.Text = string.Empty;
                txtLog.Text = string.Empty;
                txtNum.Text = string.Empty;
                txtComp.Text = string.Empty;
                txtBairro.Text = string.Empty;
                dropEstado.Text = string.Empty;
                dropCidade.Text = string.Empty;
                lblMensagem.Visible = true;
                lblMensagem.Text = "Endereço cadastrado com sucesso!";


            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Limpa dados dos campos
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTel.Text = string.Empty;            
            txtTipo.Text = string.Empty;
            txtLog.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComp.Text = string.Empty;
            txtBairro.Text = string.Empty;
            dropEstado.Text = string.Empty;
            dropCidade.Text = string.Empty;
            btnCliente.Visible = false;            
            btnIncluirEndAd.Visible = false;
            btnCadastrar.Visible = true;
            lblMensagem.Visible = false;
        }
    }

}
