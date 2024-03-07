<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nomina_de_empleados.aspx.cs" Inherits="aporte5tod.Nomina_de_empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
   <form id="form1" runat="server">
    <div class="container">
        <h1 class="display-4">Pago de Empleados</h1>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div> 
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label>
            <asp:TextBox ID="txtedad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Precio por hora"></asp:Label>
            <asp:TextBox ID="precioh" runat="server" CssClass="form-control">15,33 por dia</asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Dias trabajados"></asp:Label>
            <asp:TextBox ID="txtdiastrabajados" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Descuento IESS"></asp:Label>
            <asp:TextBox ID="txtdescuentoiess" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Descuento IR"></asp:Label>
            <asp:TextBox ID="txtdescuentoir" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
         <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Bono:"></asp:Label>
            <asp:TextBox ID="bono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
       
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="txtresultado" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="Btn_calcular" runat="server" Text="Calcular" CssClass="btn btn-primary" OnClick="Btn_calcular_Click" />
        </div>
        <asp:Button ID="Btnregistrar" runat="server" Text="Registrar" OnClick="Btnregistrar_Click" />
    </div>
</form>

</body>
</html>
