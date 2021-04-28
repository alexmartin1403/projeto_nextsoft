<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="TesteNextSoft.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<link rel="stylesheet" href="css/estilo.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    

    <title>Cadastro de Clientes - NextSoft</title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style13 {
            width: 271px;
            text-align: justify;
        }
        .auto-style14 {
            height: 33px;
            width: 271px;
        }
        .auto-style15 {
            width: 271px;
        }
        .auto-style16 {
            height: 31px;
            width: 271px;
        }
        .auto-style18 {
            height: 33px;
            width: 206px;
        }
        .auto-style19 {
            width: 206px;
        }
        .auto-style20 {
            width: 206px;
            text-align: justify;
        }
        .auto-style21 {
            height: 31px;
            width: 206px;
        }
        .auto-style23 {
            height: 33px;
            text-align: center;
            font-size: xx-large;
            font-family: Algerian;
            color: #6699FF;
        }
        .auto-style24 {
            width: 206px;
            height: 22px;
        }
        .auto-style25 {
            width: 271px;
            height: 22px;
        }
        .auto-style26 {
            height: 22px;
        }
        .auto-style29 {
            font-size: medium;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style30 {
            height: 31px;
            text-align: center;
        }
        .auto-style31 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            font-size: medium;
            color: #6699FF;
        }
        .auto-style33 {
            font-size: 20px;
        }
        </style>
</head>
<body style="height: 385px">   
    <img src="imagens/next.png"   />    
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style23" colspan="2">
                        <strong>Cadastro do Cliente</strong></td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style3" colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style14">
                        <asp:Label  runat="server" ID="lblNome" Text="Nome:" Font-Bold="true" CssClass="auto-style29"></asp:Label>  
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtNome" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                        <asp:Label runat="server" ID="lblCpf" Text="CPF:" Font-Bold="true" CssClass="auto-style29" ></asp:Label>  
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtCpf" Width="497px" BackColor="#FFFFE8" ></asp:TextBox>
                    </td>
                </tr>
                   <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                        <asp:Label runat="server" ID="lblEmail" Text="E-mail:" Font-Bold="true" CssClass="auto-style29"></asp:Label>  
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtEmail" TextMode="Email" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>
                </tr>
                   <tr>
                    <td class="auto-style20">
                        &nbsp;</td>
                    <td class="auto-style13">
                        <asp:Label runat="server" ID="lblTel" Text="Telefone com código de area:" Font-Bold="True" CssClass="auto-style29"></asp:Label>  
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtTel" TextMode="Phone" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style24"></td>
                    <td class="auto-style25"></td>
                    <td class="auto-style26">
                        </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                        <asp:Label runat="server" ID="lblTipo" Text="Tipo de Endereço:" Font-Bold="True" CssClass="auto-style29"></asp:Label>  
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtTipo" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                        <asp:Label runat="server" ID="lblLog" Text="Logradouro:" Font-Bold="True" CssClass="auto-style29"></asp:Label>  
                        </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtLog" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                        <asp:Label runat="server" ID="lblNum" Text="Número:" Font-Bold="True" CssClass="auto-style29"></asp:Label>  
                        </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtNum" TextMode="Number" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                        <asp:Label runat="server" ID="lblComp" Text="Complemento:" Font-Bold="True" CssClass="auto-style29"></asp:Label>            
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtComp" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                       <asp:Label runat="server" ID="lblBairro" Text="Bairro:" Font-Bold="True" CssClass="auto-style29"></asp:Label>   
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtBairro" Width="497px" BackColor="#FFFFE8"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        </td>
                    <td class="auto-style15">
                    <asp:Label runat="server" ID="lblEstado" Text="Estado:" Font-Bold="True" CssClass="auto-style29"></asp:Label>   
                    </td>
                    <td>
                        <asp:DropDownList ID="dropEstado" runat="server" Width="338px" DataSourceID="Estado" DataTextField="nome" DataValueField="nome" AppendDataBoundItems="true" AutoPostBack="True" BackColor="#FFFFE8" CssClass="auto-style33" >
                         <asp:ListItem Text="Por favor selecione" Value="" />
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="Estado" runat="server" ConnectionString ="<%$ ConnectionStrings:Estado %>" SelectCommand="SELECT id,nome FROM ESTADOS ORDER BY nome;" ProviderName="<%$ ConnectionStrings:Estado.ProviderName %>" ></asp:SqlDataSource>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style15">
                    <asp:Label runat="server" ID="lblCidade" Text="Cidade:" Font-Bold="True" CssClass="auto-style29"></asp:Label>   
                        </td>
                      <td>
                        <asp:DropDownList ID="dropCidade" runat="server" Width="341px" DataSourceID="Cidade" DataTextField="nome" DataValueField="nome" AppendDataBoundItems="true" BackColor="#FFFFE8" CssClass="auto-style33" >
                         <asp:ListItem Text="Por favor selecione" Value="" />
                        </asp:DropDownList>
                          <asp:SqlDataSource ID="Cidade" runat="server" ConnectionString="<%$ ConnectionStrings:Cidade %>" SelectCommand="SELECT [nome] FROM [CIDADES] ORDER BY [nome]"></asp:SqlDataSource>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style30" colspan="2">
                        <asp:Label ID="lblMensagem" runat="server" CssClass="auto-style31" Text="Label" Visible="False"></asp:Label>
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td colspan="2">
                        <asp:Button runat="server" ID="btnCadastrar" Text="Cadastrar" OnClick="btnCadastrar_Click" Width="786px" BackColor="#0033CC" ForeColor="White" Height="36px" />
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnIncluirEndAd" runat="server" BackColor="#0033CC" ForeColor="White" Height="38px" OnClick="btnIncluirEndAd_Click" Text="Incluir novo endereço" Visible="False" Width="788px" />
                    </td>

                </tr>

                <tr>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnCliente" runat="server" BackColor="#0033CC" ForeColor="White" Height="46px" OnClick="Button1_Click" Text="Cadastrar outro Cliente" Visible="False" Width="785px" />
                    </td>

                </tr>

                <tr>
                    <td class="auto-style21"></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style1">
                        </td>

                </tr>
            </table>
        </div>
        <p>
            </p>
    </form>
</body>
</html>
