<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body style="background-image:url(1.jfif)">
    
    <form id="form1" runat="server">
        <div style="height: 134px">

        </div>
        <div style="border: thin solid #C0C0C0; margin: auto; height:183px; width:387px; background-color:#000000; text-decoration-color:; font-family: Arial, Helvetica, sans-serif; font-size: medium; background-image: none;">
            <h3 style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-style: italic; color: #CCCCFF;">Login</h3>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Email:" ForeColor="#CCCCFF" Font-Size="Medium" Font-Bold="False" Font-Italic="True"></asp:Label>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="un" runat="server" Width="203px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password:" ForeColor="#CCCCFF"></asp:Label>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="p" runat="server" TextMode="Password" Width="205px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" BackColor="White" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Error" runat="server" Text="Invalid Email or Password" ForeColor="White"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
