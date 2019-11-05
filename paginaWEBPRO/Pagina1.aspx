<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="paginaWEBPRO.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Style.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <header>
      <img  class="logo" src="media/logo.png" alt="logo" width="110" height="40">
                 <asp:Label ID="lbContador" runat="server" ></asp:Label>
      
     
                 
  </header>
        </div>
<div class="sec1">
            Inicia sesion:<br />
        <br />
        <Label name="Label1" runat="server" Text="Usuario:"></Label>
&nbsp;
        user <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        <Label name="Label2" runat="server" Text="Contraseña"></Label>
        password <asp:TextBox ID="txContraseña" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Inicio sesion</asp:LinkButton>
        <br />
        <br />
        

        </div>
    </form>
</body>
</html>
