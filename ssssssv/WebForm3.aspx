<%@ Page Language="C#" AutoEventWireup="true" Code="WebForm3.aspx.cs" Inherits="ssssssv.WebForm3" %>

<!DOCTYPE html>
<script runat="server">


  
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="L1" runat="server" style="z-index: 1; left: 399px; top: 85px; position: absolute" Text="Id"></asp:Label>
            <asp:Label ID="L3" runat="server" style="z-index: 1; left: 391px; top: 223px; position: absolute" Text="Password"></asp:Label>
            <asp:Label ID="L5" runat="server" style="z-index: 1; left: 394px; top: 331px; position: absolute" Text="Age"></asp:Label>
            <asp:Label ID="L10" runat="server" style="z-index: 1; left: 396px; top: 644px; position: absolute" Text="Address"></asp:Label>
            <asp:Label ID="L6" runat="server" style="z-index: 1; left: 395px; top: 389px; position: absolute" Text="Gender"></asp:Label>
            <asp:Label ID="L7" runat="server" style="z-index: 1; left: 392px; top: 449px; position: absolute" Text="Language"></asp:Label>
            <asp:Label ID="L9" runat="server" style="z-index: 1; left: 387px; top: 588px; position: absolute" Text="Email"></asp:Label>
            <asp:Label ID="L8" runat="server" style="z-index: 1; left: 384px; top: 518px; position: absolute" Text="Phone"></asp:Label>
            <asp:Label ID="L2" runat="server" style="z-index: 1; left: 395px; top: 162px; position: absolute" Text="Name"></asp:Label>
            <asp:Label ID="L4" runat="server" style="z-index: 1; left: 396px; top: 280px; position: absolute" Text="ConfirmPassword"></asp:Label>
            <asp:TextBox ID="tb7" runat="server" style="z-index: 1; left: 603px; top: 580px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="tb2" runat="server" style="z-index: 1; left: 604px; top: 154px; position: absolute"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 628px; top: 644px; position: absolute">
            </asp:DropDownList>
            <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 608px; top: 450px; position: absolute" Text="Telugu" />
            <asp:CheckBox ID="CheckBox2" runat="server" style="z-index: 1; left: 708px; top: 449px; position: absolute" Text="English" />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" style="z-index: 1; left: 611px; top: 389px; position: absolute" Text="Male" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" style="z-index: 1; left: 698px; top: 387px; position: absolute" Text="FeMale" />
            <asp:TextBox ID="tb5" runat="server" style="z-index: 1; left: 607px; top: 335px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="tb4" runat="server" style="z-index: 1; left: 605px; top: 282px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="tb1" runat="server" style="z-index: 1; left: 605px; top: 87px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="tb3" runat="server" style="z-index: 1; left: 604px; top: 225px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="tb6" runat="server" style="z-index: 1; left: 602px; top: 520px; position: absolute"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 553px; top: 787px; position: absolute" Text="Insert" />
            <asp:Label ID="L11" runat="server" style="z-index: 1; left: 406px; top: 704px; position: absolute" Text="Photo"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" style="z-index: 1; left: 602px; top: 697px; position: absolute" />
        </div>
    </form>
</body>
</html>
