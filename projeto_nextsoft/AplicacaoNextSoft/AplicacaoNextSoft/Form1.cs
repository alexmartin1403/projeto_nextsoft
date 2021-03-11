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
        int endereco = 0;
        string tipoInicial = "";
        string api = "http://apitestnext.gearhostpreview.com";
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            pesquisarAtualizar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
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
            
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api + "/api/");
            HttpResponseMessage responseEst = clint.GetAsync("Estados").Result;

            var est = responseEst.Content.ReadAsAsync<IEnumerable<ESTADO>>().Result;

            dataGridView1.DataSource = est;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBoxEstado.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
            }

            
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
            if ((txtCPF.Text == string.Empty) || (txtNome.Text == string.Empty) || (txtEmail.Text == string.Empty) ||
                (txtTelefone.Text == string.Empty) || (txtTipo.Text == string.Empty) || (txtLogradouro.Text == string.Empty) ||
                (txtNum.Text == string.Empty) || (txtComplemento.Text == string.Empty) || (txtBairro.Text == string.Empty) ||
                (comboBoxEstado.Text == string.Empty) || (comboBoxCidade.Text == string.Empty))
            {
                MessageBox.Show("Favor preencher todos os dados");
                goto fim;
            }

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
            endereco = 1;

            if (!(txtEmail.Text.Contains("@")) || !(txtEmail.Text.Contains(".")))
            {
                MessageBox.Show("Preencha o e-mail corretamente");
                goto fim;
            }

            ClienteValidacaoCpf clienteCpf = new ClienteValidacaoCpf();

            if (!clienteCpf.ValidaCPF(txtCPF.Text))
            {
                MessageBox.Show("CPF inválido");
                goto fim;
            }

            if ((txtTelefone.Text.Length < 10) && (!Regex.IsMatch(txtTelefone.Text, @"^[0-9]+$")))
            {
                MessageBox.Show("Número de Tefone incorreto");
                goto fim;
            }


            CLIENTE cli = new CLIENTE() { CPF = txtCPF.Text, NOME = txtNome.Text, EMAIL = txtEmail.Text, TELEFONE = txtTelefone.Text };
            HttpResponseMessage responseCli = clint.PostAsJsonAsync("Clientes", cli).Result;

            ENDERECOS end = new ENDERECOS();

            HttpResponseMessage responseEnd = clint.PostAsJsonAsync("Enderecos?cpf=" + txtCPF.Text + "&tipo="
                + txtTipo.Text + "&logradouro=" + txtLogradouro.Text + "&numero=" + txtNum.Text + "&complemento=" +
                txtComplemento.Text + "&bairro=" + txtBairro.Text + "&estado=" +  comboBoxEstado.Text + "&cidade=" +
                comboBoxCidade.Text, end).Result;
            btnIcluirEndereco.Visible = true;

            txtTipo.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            comboBoxCidade.Text = string.Empty;
            comboBoxEstado.Text = string.Empty;
            MessageBox.Show("Cadastro realizado com sucesso");
        fim:;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
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
            endereco = 0;
            btnIncluirEndAd.Visible = false;
            txtEstado.Visible = true;
            txtCidade.Visible = true;
            comboBoxEstado.Visible = false;
            comboBoxCidade.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                HttpClient clint = new HttpClient();
                clint.BaseAddress = new Uri(api + "/api/");
                HttpResponseMessage responseCli = clint.DeleteAsync("Clientes?cpf=" + txtCPF.Text).Result;

                HttpResponseMessage responseEnd = clint.DeleteAsync("Enderecos?cpf=" + txtCPF.Text).Result;
            }
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
            txtTipo.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            comboBoxEstado.Text = string.Empty;
            comboBoxCidade.Text = string.Empty;
            btnIcluirEndereco.Visible = false;
            endereco++;
            btnIncluirEndAd.Visible = true;
            btnIncluirEndAd.Text = "Incluir Endereço " + endereco;
        }

        private void btnIncluirEndAd_Click(object sender, EventArgs e)
        {
            if ((txtCPF.Text == string.Empty) || (txtTipo.Text == string.Empty) || (txtLogradouro.Text == string.Empty) ||
                (txtNum.Text == string.Empty) || (txtComplemento.Text == string.Empty) || (txtBairro.Text == string.Empty) ||
                (txtEstado.Text == string.Empty) || (txtCidade.Text == string.Empty))
            {

                HttpClient clint = new HttpClient();
                clint.BaseAddress = new Uri(api + "/api/");

                ENDERECOS end = new ENDERECOS();

                HttpResponseMessage responseEnd = clint.PostAsJsonAsync("Enderecos?cpf=" + txtCPF.Text + "&tipo="
                    + txtTipo.Text + "&logradouro=" + txtLogradouro.Text + "&numero=" + txtNum.Text + "&complemento=" +
                    txtComplemento.Text + "&bairro=" + txtBairro.Text + "&estado=" + txtEstado.Text + "&cidade=" +
                    txtCidade.Text, end).Result;

                txtTipo.Text = string.Empty;
                txtLogradouro.Text = string.Empty;
                txtNum.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                txtBairro.Text = string.Empty;
                comboBoxEstado.Text = string.Empty;
                comboBoxCidade.Text = string.Empty;
                btnIncluirEndAd.Visible = false;
                btnIcluirEndereco.Visible = true;
            }


        }
        private void pesquisarAtualizar()
        {
            comboBoxNumEnd.Items.Clear();

            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api + "/api/");
            HttpResponseMessage responseCli = clint.GetAsync("Clientes?cpf=" + txtCPF.Text).Result;

            var cli = responseCli.Content.ReadAsAsync<IEnumerable<CLIENTE>>().Result;

            dataGridView1.DataSource = cli;

            if (dataGridView1.RowCount == 0)
            {
                goto fim;
            }

            txtNome.Text = Convert.ToString(dataGridView1.Rows[0].Cells[2].Value);

            txtEmail.Text = Convert.ToString(dataGridView1.Rows[0].Cells[3].Value);

            txtTelefone.Text = Convert.ToString(dataGridView1.Rows[0].Cells[4].Value);

            HttpResponseMessage responseEnd = clint.GetAsync("Enderecos?cpf=" + txtCPF.Text).Result;

            var end = responseEnd.Content.ReadAsAsync<IEnumerable<ENDERECOS>>().Result;

            dataGridView1.DataSource = end;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBoxNumEnd.Items.Add(i + 1);
            }
        fim:;
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
