<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PLC_Veri_Yazma.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 261px;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 206px;
            height: 27px;
        }
        .auto-style4 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Sıra"></asp:TextBox>
                    </td>
                    <td>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Deger"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style4">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
       
    </form>
</body>
</html>
