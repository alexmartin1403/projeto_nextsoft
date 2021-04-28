using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using Nancy.Json;
using RestSharp;
using System.Text.RegularExpressions;

namespace AplicacaoNextSoft

{

    public partial class Form1 : Form
    {
        //inicialização de variáveis
        int endereco = 1;
        string tipoInicial = "";
        string api = "http://apitestnext.gearhostpreview.com";
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chama metodo pesquisarAtualizar
            pesquisarAtualizar();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            //preenchendo os dados de endereço, quando o combo de numeração é alterado
            int selectedValue = comboBoxNumEnd.SelectedIndex;
            txtTipo.Text = Convert.ToString(dataGridView1.Rows[selectedValue].Cells[2].Value);
            txtLogradouro.Text = Convert.ToString(dataGridView1.Rows[selectedValue].Cells[3].Value);
            txtNum.Text = Convert.ToString(dataGridView1.Rows[selectedValue].Cells[4].Value);
            txtComplemento.Text = Convert.ToString(dataGridView1.Rows[selectedValue].Cells[5].Value);
            txtBairro.Text = Convert.ToString(dataGridView1.Rows[selectedValue].Cells[6].Value);
            txtEstado.Text = Convert.ToString(dataGridView1.Rows[selectedValue].Cells[7].Value);
            txtCidade.Text = Convert.ToString(dataGridView1.Rows[selectedValue].Cells[7].Value);
            tipoInicial = txtTipo.Text;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Utilizando o PUT através da API para salvar as alterações nos dados do cliente e dos endereços
            CLIENTE cli = new CLIENTE();
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api + "/api/");
            HttpResponseMessage responseCli = clint.PutAsJsonAsync("Clientes?cpf=" + txtCPF.Text + "&nome="
                + txtNome.Text + "&email=" + txtEmail.Text + "&telefone=" + txtTelefone.Text, cli).Result;

            ENDERECOS end = new ENDERECOS();
            HttpResponseMessage responseEnd = clint.PutAsJsonAsync("Enderecos?cpf=" + txtCPF.Text + "&tipo="
                + txtTipo.Text + "&logradouro=" + txtLogradouro.Text + "&numero=" + txtNum.Text + "&complemento=" +
                txtComplemento.Text + "&bairro=" + txtBairro.Text + "&estado=" + txtEstado.Text + "&cidade=" +
                txtCidade.Text + "&tipo2=" + tipoInicial, end).Result;

            //Atulizando os dados após a alteração
            pesquisarAtualizar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Apaga os campos para a inclusão de um novo cliente
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            btnPesquisar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = false;
            lblNumEnd.Visible = false;
            comboBoxNumEnd.Visible = false;
            btnCadastrar.Visible = false;
            txtTipo.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            btnIncluirNovo.Visible = true;
            btnVoltar.Visible = true;
            comboBoxNumEnd.Items.Clear();
            comboBoxNumEnd.Text = string.Empty;
            txtEstado.Visible = false;
            comboBoxEstado.Visible = true;
            txtCidade.Visible = false;
            comboBoxCidade.Visible = true;
            
            //Lê os dados da tabela estados e preenche os dados no combo box
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api + "/api/");
            HttpResponseMessage responseEst = clint.GetAsync("Estados").Result;

            var est = responseEst.Content.ReadAsAsync<IEnumerable<ESTADO>>().Result;

            dataGridView1.DataSource = est;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBoxEstado.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
            }

            //Lê os dados da tabela cidades e preenche os dados no combo box
            HttpResponseMessage responseCid = clint.GetAsync("Cidades").Result;

            var cid = responseCid.Content.ReadAsAsync<IEnumerable<CIDADES>>().Result;

            dataGridView1.DataSource = cid;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBoxCidade.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
            }
            
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {           

            //Verifica se os campos foram preenchidos
            if ((txtCPF.Text == string.Empty) || (txtNome.Text == string.Empty) || (txtEmail.Text == string.Empty) ||
                (txtTelefone.Text == string.Empty) || (txtTipo.Text == string.Empty) || (txtLogradouro.Text == string.Empty) ||
                (txtBairro.Text == string.Empty) ||(comboBoxEstado.Text == string.Empty) || (comboBoxCidade.Text == string.Empty))
            {
                MessageBox.Show("Favor preencher todos os dados");
                goto fim;
            }

            //Consulta o CPF no banco e verifica se ele já existe
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api + "/api/");
            HttpResponseMessage responseCliP = clint.GetAsync("Clientes?cpf=" + txtCPF.Text).Result;

            var cliPesq = responseCliP.Content.ReadAsAsync<IEnumerable<CLIENTE>>().Result;

            dataGridView1.DataSource = cliPesq;

            if (dataGridView1.RowCount > 0)
            {
                MessageBox.Show("Esse CPF já existe");
                goto fim;
            }

            //Seta a variável com o valor 1
            endereco = 1;

            //Verifica se o campo e-mail não possui o caractere "@" ou o caractere "."
            if (!(txtEmail.Text.Contains("@")) || !(txtEmail.Text.Contains(".")))
            {
                MessageBox.Show("Preencha o e-mail corretamente");
                goto fim;
            }

            //Instancia o metodo e verifica se o CPF é válido
            ClienteValidacaoCpf clienteCpf = new ClienteValidacaoCpf();

            if (!clienteCpf.ValidaCPF(txtCPF.Text))
            {
                MessageBox.Show("CPF inválido");
                goto fim;
            }

            // Verifica se o campo telefone tem menos de 10 carecteres e se é um número
            if ((txtTelefone.Text.Length < 10) || (!Regex.IsMatch(txtTelefone.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Número de Tefone incorreto");
                goto fim;
            }

            // Verifica se o campo número do logradouro foi preenchido com um número
            if ((!Regex.IsMatch(txtNum.Text, @"^[0-9]+$"))&&(txtNum.Text != ""))
            {
                MessageBox.Show("Número do logradouro incorreto");
                goto fim;
            }

            //Inclui no banco os dados do cliente e de seus endereços, através da API
            CLIENTE cli = new CLIENTE() { CPF = txtCPF.Text, NOME = txtNome.Text, EMAIL = txtEmail.Text, TELEFONE = txtTelefone.Text };
            HttpResponseMessage responseCli = clint.PostAsJsonAsync("Clientes", cli).Result;

            ENDERECOS end = new ENDERECOS();

            HttpResponseMessage responseEnd = clint.PostAsJsonAsync("Enderecos?cpf=" + txtCPF.Text + "&tipo="
                + txtTipo.Text + "&logradouro=" + txtLogradouro.Text + "&numero=" + txtNum.Text + "&complemento=" +
                txtComplemento.Text + "&bairro=" + txtBairro.Text + "&estado=" +  comboBoxEstado.Text + "&cidade=" +
                comboBoxCidade.Text, end).Result;
            
            //Limpa os campos de endereço
            txtTipo.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            comboBoxCidade.Text = string.Empty;
            comboBoxEstado.Text = string.Empty;

            //Informa o cadastramento ao usuário
            MessageBox.Show("Cadastro realizado com sucesso");

            //Atuliza a numeração do endereço
            endereco++;
            lblEndAd.Text = "Endereço " + endereco;

            btnIcluirEndereco.Visible = true;
        fim:;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Limpa e habilita/desabilita os campos ao voltar para a tela inicial
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            comboBoxCidade.Text = string.Empty;
            comboBoxEstado.Text = string.Empty;
            btnPesquisar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = true;
            lblNumEnd.Visible = true;
            comboBoxNumEnd.Visible = true;
            btnCadastrar.Visible = true;
            btnIncluirNovo.Visible = false;
            btnVoltar.Visible = false;
            btnIcluirEndereco.Visible = false;
            comboBoxNumEnd.Items.Clear();
            comboBoxNumEnd.Text = string.Empty;
            lblEndAd.Text = "";         
            txtEstado.Visible = true;
            txtCidade.Visible = true;
            comboBoxEstado.Visible = false;
            comboBoxCidade.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Exclui cliente do banco baseado no número de CPF digitado
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                HttpClient clint = new HttpClient();
                clint.BaseAddress = new Uri(api + "/api/");
                HttpResponseMessage responseCli = clint.DeleteAsync("Clientes?cpf=" + txtCPF.Text).Result;

                HttpResponseMessage responseEnd = clint.DeleteAsync("Enderecos?cpf=" + txtCPF.Text).Result;
            }
            //Limpa os campos
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            comboBoxNumEnd.Text = string.Empty;
            comboBoxNumEnd.Items.Clear();

        }

        private void btnIcluirEndereco_Click(object sender, EventArgs e)
        {
            //Soma um a variável de endereço
            endereco++;

            //Veifica se os campos não estão em branco e se o campo número esta preenchido com um número.
            if (((txtCPF.Text == string.Empty) || (txtTipo.Text == string.Empty) || (txtLogradouro.Text == string.Empty) 
                || (txtBairro.Text == string.Empty) || (txtEstado.Text == string.Empty) || (txtCidade.Text == string.Empty))
                && ((!Regex.IsMatch(txtNum.Text, @"^[0-9]+$")) && (txtNum.Text != "")))
            {
                MessageBox.Show("Favor preencher todos os dados corretamente");
                endereco--;
            }
            else
            {
                //Inclui os dados do cliente e dos seus endereços
                HttpClient clint = new HttpClient();
                clint.BaseAddress = new Uri(api + "/api/");

                ENDERECOS end = new ENDERECOS();

                HttpResponseMessage responseEnd = clint.PostAsJsonAsync("Enderecos?cpf=" + txtCPF.Text + "&tipo="
                    + txtTipo.Text + "&logradouro=" + txtLogradouro.Text + "&numero=" + txtNum.Text + "&complemento=" +
                    txtComplemento.Text + "&bairro=" + txtBairro.Text + "&estado=" + comboBoxEstado.Text + "&cidade=" +
                    comboBoxCidade.Text, end).Result;

                //Limpa os campos
                txtTipo.Text = string.Empty;
                txtLogradouro.Text = string.Empty;
                txtNum.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                txtBairro.Text = string.Empty;
                comboBoxEstado.Text = string.Empty;
                comboBoxCidade.Text = string.Empty;
                btnIcluirEndereco.Visible = true;

                //Informa o cadastramento ao usuário
                MessageBox.Show("Cadastro realizado com sucesso");
            }



            //Mostra o endereço que está sendo cadastrado
            lblEndAd.Text = "Endereço " + endereco;

        }

            private void pesquisarAtualizar()
        {   
            //Limpa os campos
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            comboBoxNumEnd.Text = string.Empty;
            comboBoxNumEnd.Items.Clear();

            //Procura no banco, o CPF digitado, através da API 
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api + "/api/");
            HttpResponseMessage responseCli = clint.GetAsync("Clientes?cpf=" + txtCPF.Text).Result;

            var cli = responseCli.Content.ReadAsAsync<IEnumerable<CLIENTE>>().Result;

            //Preenche o datagrid
            dataGridView1.DataSource = cli;

            //Finaliza processo se o datagrid estiver em branco
            if (dataGridView1.RowCount == 0)
            {
                goto fim;
            }

            //Prenche os campos com os dados do datagrid
            txtNome.Text = Convert.ToString(dataGridView1.Rows[0].Cells[2].Value);

            txtEmail.Text = Convert.ToString(dataGridView1.Rows[0].Cells[3].Value);

            txtTelefone.Text = Convert.ToString(dataGridView1.Rows[0].Cells[4].Value);

            //Pesquisa no banco os endereços encontrados nesse CPF
            HttpResponseMessage responseEnd = clint.GetAsync("Enderecos?cpf=" + txtCPF.Text).Result;

            var end = responseEnd.Content.ReadAsAsync<IEnumerable<ENDERECOS>>().Result;

            //Preenche o datagrid com os endereços encontrados
            dataGridView1.DataSource = end;

            //prenche o combo box com a quantidade de endereços encontrados
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBoxNumEnd.Items.Add(i + 1);
            }

            comboBoxNumEnd.Text = "1";

        fim:;
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
