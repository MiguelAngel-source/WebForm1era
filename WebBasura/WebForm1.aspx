 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebBasura.WebForm1" %>

<!DOCTYPE html>


<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Estilo.css" />
    <script src="Script/jquery.js"></script>
    <link href="ccs/jquery-ui.css" rel="stylesheet" />
    <script src="Script/jquery-ui.js"></script>
    

    <script type="text/javascript">
        $(document).ready(function () {
            $("#txtDate").datepicker({
                dateFormat: 'yy-mm-dd'
            });
      });
    </script>   

</head> 
<body>
    <h1 style="text-align:center; font-family: Arial, Helvetica, sans-serif; color: #0000FF; line-height: normal; background-color: #C0C0C0;"
        >Bienvenidos a la Pagina de Ventas</h1>
    <form id="form1" runat="server" method="post">
        <div>
            <label id="Label1" for =fname>Nombre</label>
            <asp:TextBox ID="TextBoxNom" runat="server"></asp:TextBox>
            <br /><br />
            <label for=Lname>Apellido</label>
            <asp:TextBox ID="TextBoxApp" runat="server"></asp:TextBox>
            <br /><br />
            Fecha rsv&nbsp;<asp:TextBox ID="txtDate" runat="server" OnTextChanged="txtDate_TextChanged"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Medio dia"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="Button" Width="94px" />
        </p>
        <p>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </p>
        <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Segunda webform" />
        </p>
        

     
        <p>
            &nbsp;</p>
        <p>
        

     
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
        

     
        </p>
        

     
    </form>
</body>
</html>
