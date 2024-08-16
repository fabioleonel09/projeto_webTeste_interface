<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webTesteInterface._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>WebTeste Interface</title>

    </head>

    <body>
        <form id="frmInicial" runat="server" style="width: 100%; height: 100%;">
            <asp:GridView ID="gdvInicial" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="UsuariosSenhasId" HeaderText="Identificação"/>
                    <asp:BoundField DataField="Usuario" HeaderText="Usuário"/>
                    <asp:BoundField DataField="Senha" HeaderText="Senha"/>
                    <asp:BoundField DataField="Competencia" HeaderText="Competência"/>
                </Columns>
            </asp:GridView>
        </form>
    </body>
</html>


