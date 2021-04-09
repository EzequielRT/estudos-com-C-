<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormsApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TxtMensagem" runat="server"></asp:TextBox>
        <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="Mostrar mensagem" />
    </form>
</body>
</html>
