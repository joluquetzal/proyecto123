<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagina2.aspx.cs" Inherits="paginaWEBPRO.pagina2" %>

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
      <nav>
          <ul class="nav_links">
              <li><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/pagina2.aspx">inicio</asp:LinkButton></li>
              <li><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Materias</asp:LinkButton></li>
              <li><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Profesores</asp:LinkButton></li> 
              <li><asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Departamentos</asp:LinkButton></li>
              <li><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Modificar Servicios</asp:LinkButton></li>
          </ul>
      </nav>
     
                 
  </header>
        </div>
    </form>
</body>
</html>
