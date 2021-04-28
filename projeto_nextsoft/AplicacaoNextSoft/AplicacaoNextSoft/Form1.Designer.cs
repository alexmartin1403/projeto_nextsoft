
namespace AplicacaoNextSoft
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEndAd = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNumEnd = new System.Windows.Forms.Label();
            this.comboBoxNumEnd = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnIncluirNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnIcluirEndereco = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(299, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 59);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar por CPF";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(60, 43);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(46, 25);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 102);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 25);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 102);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(807, 31);
            this.txtNome.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 450);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(737, 28);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 31);
            this.txtEmail.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(478, 158);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(165, 25);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone com DDD:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(678, 155);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(237, 31);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.lblEndAd);
            this.groupBox1.Controls.Add(this.comboBoxCidade);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.lblNum);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.lblLogradouro);
            this.groupBox1.Controls.Add(this.lblNumEnd);
            this.groupBox1.Controls.Add(this.comboBoxNumEnd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(27, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 244);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // lblEndAd
            // 
            this.lblEndAd.AutoSize = true;
            this.lblEndAd.Location = new System.Drawing.Point(19, 41);
            this.lblEndAd.Name = "lblEndAd";
            this.lblEndAd.Size = new System.Drawing.Size(0, 25);
            this.lblEndAd.TabIndex = 22;
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(635, 200);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(253, 33);
            this.comboBoxCidade.TabIndex = 21;
            this.comboBoxCidade.Visible = false;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(333, 200);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(209, 33);
            this.comboBoxEstado.TabIndex = 20;
            this.comboBoxEstado.Visible = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(602, 41);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(286, 31);
            this.txtTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(491, 44);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 25);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(635, 200);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(253, 31);
            this.txtCidade.TabIndex = 18;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(333, 202);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(209, 31);
            this.txtEstado.TabIndex = 17;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(558, 203);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(71, 25);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(257, 203);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 25);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(88, 203);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(163, 31);
            this.txtBairro.TabIndex = 13;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(20, 206);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(62, 25);
            this.lblBairro.TabIndex = 12;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(342, 146);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(546, 31);
            this.txtComplemento.TabIndex = 11;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(206, 149);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(130, 25);
            this.lblComplemento.TabIndex = 11;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(107, 149);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(81, 31);
            this.txtNum.TabIndex = 11;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(20, 149);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(81, 25);
            this.lblNum.TabIndex = 11;
            this.lblNum.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(136, 88);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(752, 31);
            this.txtLogradouro.TabIndex = 11;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(20, 91);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(110, 25);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblNumEnd
            // 
            this.lblNumEnd.AutoSize = true;
            this.lblNumEnd.Location = new System.Drawing.Point(20, 41);
            this.lblNumEnd.Name = "lblNumEnd";
            this.lblNumEnd.Size = new System.Drawing.Size(255, 25);
            this.lblNumEnd.TabIndex = 1;
            this.lblNumEnd.Text = "Selecione o Num do Endereço:";
            // 
            // comboBoxNumEnd
            // 
            this.comboBoxNumEnd.FormattingEnabled = true;
            this.comboBoxNumEnd.Location = new System.Drawing.Point(294, 38);
            this.comboBoxNumEnd.Name = "comboBoxNumEnd";
            this.comboBoxNumEnd.Size = new System.Drawing.Size(54, 33);
            this.comboBoxNumEnd.TabIndex = 0;
            this.comboBoxNumEnd.SelectedValueChanged += new System.EventHandler(this.comboBoxTipo_SelectedValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(423, 26);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(156, 59);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar Alteração";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(585, 26);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(147, 59);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir Cliente (CPF)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(738, 26);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(177, 59);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar Novo Cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnIncluirNovo
            // 
            this.btnIncluirNovo.AccessibleName = resources.GetString("btnIncluirNovo.AccessibleName");
            this.btnIncluirNovo.Location = new System.Drawing.Point(299, 26);
            this.btnIncluirNovo.Name = "btnIncluirNovo";
            this.btnIncluirNovo.Size = new System.Drawing.Size(433, 59);
            this.btnIncluirNovo.TabIndex = 14;
            this.btnIncluirNovo.Text = "Incluir Cliente Novo";
            this.btnIncluirNovo.UseVisualStyleBackColor = true;
            this.btnIncluirNovo.Visible = false;
            this.btnIncluirNovo.Click += new System.EventHandler(this.btnCadastrarNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(738, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(177, 58);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnIcluirEndereco
            // 
            this.btnIcluirEndereco.AccessibleName = resources.GetString("btnIcluirEndereco.AccessibleName");
            this.btnIcluirEndereco.Location = new System.Drawing.Point(27, 450);
            this.btnIcluirEndereco.Name = "btnIcluirEndereco";
            this.btnIcluirEndereco.Size = new System.Drawing.Size(888, 37);
            this.btnIcluirEndereco.TabIndex = 16;
            this.btnIcluirEndereco.Text = "Incluir endereço adicional";
            this.btnIcluirEndereco.UseVisualStyleBackColor = true;
            this.btnIcluirEndereco.Visible = false;
            this.btnIcluirEndereco.Click += new System.EventHandler(this.btnIcluirEndereco_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(112, 40);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(166, 31);
            this.txtCPF.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 504);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnIcluirEndereco);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnIncluirNovo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cadastro de Clientes - Next Soft";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumEnd;
        private System.Windows.Forms.ComboBox comboBoxNumEnd;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox o;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnIncluirNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnIcluirEndereco;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label lblEndAd;
    }
}

