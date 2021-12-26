<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebApplication1.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <topnav>
        <h3>ADD new Empolyee</h3>
    </topnav>
    <form id="form1" runat="server">
        <div>
            <h5>Enter Empoyee Data</h5>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Employee ID : " ForeColor="#CCCCFF" Font-Size="Medium" Font-Bold="False" Font-Italic="True"></asp:Label>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="eid" runat="server" Width="203px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Empoyee Name:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="n" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Empoyee Email : " ForeColor="#CCCCFF"></asp:Label>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="em" runat="server" Width="205px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lable4" runat="server" Text="Empoyee Contact # "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="ec" runat="server" Width="205px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Password for Employee : "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="p" runat="server" Width="205px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Area : "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="a" runat="server" Width="205px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="add" runat="server" Text="ADD" OnClick="add_Click" Width="152px" />
                    </td>
                    <td>
                        <asp:Button ID="back" runat="server" Text="Back" Width="93px" OnClick="back_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="msg" runat="server" Text="Empoyee is Added"></asp:Label>
                    </td>
                </tr>
              
            </table>
        </div>
    </form>
</body>
</html>
