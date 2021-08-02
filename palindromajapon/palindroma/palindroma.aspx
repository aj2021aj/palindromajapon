<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="palindroma.aspx.cs" Inherits="palindromajapon.palindroma.palindroma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="lblinverso" runat="server" Text="Texto: "></asp:Label>
        <asp:TextBox ID="txtoracion" runat="server" Width="377px"></asp:TextBox>
        <asp:Button ID="btn_validar" runat="server" Text="BUSCAR" OnClick="btn_validar_Click" />
        <br />
           <asp:Label ID="lblresultado" runat="server" Text="Palíndromos: "></asp:Label>
                <asp:TextBox ID="txttotal" runat="server" Width="87px" Enabled="False" ></asp:TextBox>
        
  <br />

        
    
    </div>
      

    </form>
</body>
</html>
