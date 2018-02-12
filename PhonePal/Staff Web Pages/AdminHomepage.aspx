<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHomepage.aspx.cs" Inherits="AdminHomepage" %>

<!DOCTYPE html>
<html>
<head>
    <title> Phone Pal Admin </title>

    <!--link to stlesheet-->
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>

<body>
    <form id="container" runat="server">

        <div id="header">
            <table style="width:360px">
                <tr>
                    <td><img src="molumen_phone_icon.png" height="50" width="50" /></td>
                    <td><h1>Phone Pal</h1></td>
                </tr>
            </table>
        </div>

        <div id="main">
                
                 <h2> Homepage </h2> 
                    <asp:Button ID="btnUpdateStaff" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style2" Text="Update Staff Details" OnClick="btnUpdateStaff_Click" />
                    <br />
                    <asp:Button ID="btnDisplayStaff" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style2" Text="Display Staff Deatils" OnClick="btnDisplayStaff_Click" />
                    <br />
                    <asp:Button ID="btnSearchAdmin" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style2" Text="Search Staff" OnClick="btnSearchAdmin_Click" />
                    <br />
                    <asp:Button ID="btnAddAdmin" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style2" Text="Add Staff Details" OnClick="btnAddAdmin_Click" />
            <br />
            </div>
        </form>
        
        <br />

        <div id="footer">
            <h5> &copy; Phone Pal</h5>
        </div>

</body>
</html>

