<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Contract_Web_Pages_Delete" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">

       
        .auto-style1 {
            height: 301px;
        }

       
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="header">
            <table style="width:360px">
                <tr>
                        <td><img src="../molumen_phone_icon.png" height="50" width="50" /></td>
                    <td><h1>Phone Pal</h1></td>
                </tr>
            </table>
        </div>
        <div id="content">
            <div id="nav">
                <table style="width:860px">
                    <tr>
                        <td><a href="Home.html"><ins>Home</ins></a></td>
                        <td><a href="Manufacturer.html"><ins>Manufacturers</ins></a></td>
                        <td><a href="Accessories.html"><ins>Accessories</ins></a></td>
                        <td><a href="Contract.html"><ins>Contracts</ins></a></td>
                        <td><a href="Customer.html"><ins>Customer</ins></a></td>
                        <td><a href="Staff.html"><ins>Staff</ins></a></td>
                    </tr>
                </table>

            </div>
            <div id="main" class="auto-style1">
                <center>


                        <h2>Delete Your Contract?</h2>

                    
                    <p class="auto-style2">
                        <br /><br />
                        <asp:Label ID="lblAreYouSure" runat="server" CssClass="auto-style8" Text="Are You Sure You Want To Delete This Contract?" Font-Bold="True"></asp:Label>
                               <br /><br /><br /><br />
                        <asp:Button ID="btnDeleteYes" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="button" Font-Bold="True" Height="30px" OnClick="btnDeleteYes_Click" Text="Yes" Width="90px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnDeleteNo" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="button" Font-Bold="True" Height="30px" OnClick="btnDeleteNo_Click" Text="No" Width="90px" />
                 
                        
                    

                </center>
                <br />

            </div>

            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>
