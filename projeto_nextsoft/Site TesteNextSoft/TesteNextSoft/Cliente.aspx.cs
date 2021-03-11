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
            cadastrar();
        }

        
        public void cadastrar()
        {
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
                if (clienteCpf.ValidaCPF(txtCpf.Text))
                {
                    if ((txtTel.Text.Length < 10) && (!Regex.IsMatch(txtTel.Text, @"^[0-9]+$")))
                    {
                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Número de Tefone incorreto";                        
                    }
                    else
                    {
                        if (clienteService.validarExistCPF(txtCpf.Text))
                        {
                            clienteService.cadastrarCliente(txtNome.Text, txtCpf.Text, txtEmail.Text, txtTel.Text);
                            clienteService.cadastrarEndereco(txtCpf.Text, txtTipo.Text, txtLog.Text, txtNum.Text, txtComp.Text, txtBairro.Text, dropEstado.Text, dropCidade.Text);

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
                            lblMensagem.Visible = true;
                            lblMensagem.Text = "CPF já existe!";                            
                        }

                    }
                }
                else
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "CPF Inválido!";                    
                }
            }

        }

        

        protected void btnIncluirEndAd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCpf.Text) || string.IsNullOrEmpty(txtTipo.Text) || string.IsNullOrEmpty(txtLog.Text)
                || string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(dropEstado.Text)
                || string.IsNullOrEmpty(dropCidade.Text))
            {
                MessageBox.Show("Favor preencher todos os campos necessários");
            }
            else
            {
                clienteService.cadastrarEndereco(txtCpf.Text, txtTipo.Text, txtLog.Text, txtNum.Text, txtComp.Text, txtBairro.Text, dropEstado.Text, dropCidade.Text);

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
