<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ssssssv.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" >
            <table >
                <tr>
                  <td> <asp:Label id="Label1" runat="server" Text="Id" ></asp:Label></td>
               <td> <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
                </tr>
                 <tr>
                  <td> <asp:Label id="Label2" runat="server" Text="Name" ></asp:Label></td>
               <td> <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="label3"  runat="server" Text="Password" ></asp:Label></td>
                    <td><asp:TextBox ID="txt3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="label4"  runat="server" Text="Address" ></asp:Label></td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                </tr>
              
               
            </table>
        </div>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 595px; top: 187px; position: absolute; height: 33px" Text="Button" />
        
    </form>
</body>
</html>
