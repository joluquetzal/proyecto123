<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="paginaWEBPRO.Agregar" %>

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
              <li><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Modificar Servicios</asp:LinkButton></li>
          </ul>
      </nav>
      
  </header>
        

            <div class="grid-container">
  <div class="grid-item item1">Lugar 
                <asp:TextBox ID="TextBox1" runat="server" CssClass="nav_links" ForeColor="White"></asp:TextBox></div>
  <div class="grid-item item2" aria-checked="true">Tipo
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="nav_links" ForeColor="White"></asp:TextBox></div>
  <div class="grid-item item3">departamento
                        <asp:DropDownList ID="DropDownList1" runat="server" ForeColor="White"  AutoPostBack="True"></asp:DropDownList></div>  
  <div class="grid-item item4">Materia
                            <asp:DropDownList ID="DropDownList2" runat="server" ForeColor="White" AutoPostBack="True"  ></asp:DropDownList></div>
  <div class="grid-item item5">Hora inicio
                                <asp:TextBox ID="TextBox3" runat="server" ForeColor="White"></asp:TextBox></div>
  <div class="grid-item item6">Hora fin
                                    <asp:TextBox ID="TextBox4" runat="server" ForeColor="White"></asp:TextBox></div>
  <div class="grid-item item7">Dias de la semana
                                        <asp:TextBox ID="TextBox5" runat="server" ForeColor="White"></asp:TextBox></div>
  <div class="grid-item item8">id docentes
                                            <asp:DropDownList ID="DropDownList3" runat="server" ForeColor="White" AutoPostBack="True"></asp:DropDownList></div>  
  <div class="grid-item item9"><asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton4_Click">Agregar</asp:LinkButton></div> 
  
</div>
            
        </div>
        </form>
    
 
</body>
    </html>
