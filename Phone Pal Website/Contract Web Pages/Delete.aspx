<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Contract_Web_Pages_Delete" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">

        .auto-style2 {
            height: 529px;
        }
        .auto-style6 {
            position: absolute;
            top: 445px;
            left: 400px;
            z-index: 1;
            height: 25px;
            margin-top: 0px;
        }
        .auto-style7 {
            position: absolute;
            top: 445px;
            z-index: 1;
            left: 545px;
        }
        .auto-style8 {
            position: absolute;
            top: 385px;
            left: 370px;
            z-index: 1;
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
            <div id="main">
                <center>


                        <h2>Delete Contract</h2>


                    <p class="auto-style2">
                        <asp:Button ID="btnDeleteYes" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style6" Font-Bold="True" Height="30px" OnClick="btnDeleteYes_Click" Text="Yes" Width="90px" />
                        <asp:Button ID="btnDeleteNo" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style7" Font-Bold="True" Height="30px" OnClick="btnDeleteNo_Click" Text="No" Width="90px" />
                        <asp:Label ID="lblAreYouSure" runat="server" CssClass="auto-style8" Text="Are You Sure You Want To Delete This Contract?"></asp:Label>
                    

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
