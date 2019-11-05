<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="paginaWEBPRO.Profesores" %>

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
              <li><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Departamentos</asp:LinkButton></li>
              <li><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Modificar Servicios</asp:LinkButton></li>
          </ul>
      </nav>
      
  </header>
            <div class="sec2">
                <nav class="nav_links"><ul>
  <li><a><asp:ListBox ID="ListBox1" runat="server" text-align="center"
    font=" 800 3em/1 , sans-serif"
    letter-spacing=" 0"
    color=" rgba(253, 253, 253, 0.753)"
    padding=" 50px 20px 20px"
    display=" block"
    margin=" 0 auto" AutoPostBack="True" CssClass="materias" ForeColor="#FF99FF" Width="259px" Height="156px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"
    ></asp:ListBox></a></li>
                <li><asp:GridView ID="tabla" runat="server"></asp:GridView></li>
</ul></nav>
</div>
        </div>
    </form>
</body>
    </html>
