<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cancel Contract.aspx.cs" Inherits="Cancel_Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">

        .auto-style1 {
            position: absolute;
            top: 614px;
            left: 520px;
            z-index: 1;
            height: 40px;
            margin-top: 21px;
            width: 190px;
            bottom: 27px;
        }
        .auto-style2 {
            height: 529px;
        }
        .auto-style3 {
            position: absolute;
            top: 699px;
            left: 665px;
            z-index: 1;
            height: 40px;
            margin-top: 21px;
        }
        .auto-style4 {
            position: absolute;
            top: 375px;
            left: 650px;
            z-index: 1;
            width: 160px;
            bottom: 302px;
            margin-top: 0px;
        }
        .auto-style5 {
            position: absolute;
            top: 614px;
            left: 750px;
            z-index: 1;
            height: 40px;
            margin-top: 21px;
            width: 190px;
            bottom: 118px;
        }
        .auto-style6 {
            position: absolute;
            top: 330px;
            left: 650px;
            z-index: 1;
            width: 165px;
        }
        .auto-style7 {
            position: absolute;
            top: 330px;
            left: 500px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 370px;
            left: 490px;
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
                        <td><img src="molumen_phone_icon.png" height="50" width="50" /></td>
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


                        <h2>Cancel Contract</h2>


                    <p class="auto-style2">
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" CssClass="auto-style3" Font-Bold="True" Height="40px" OnClick="btnGoBack_Click" Text="Go Back" Width="133px" BorderColor="#41719C" />
                    

                        <asp:Button ID="btnUndo" runat="server" BackColor="#6FC0D3" CssClass="auto-style5" Font-Bold="True" Height="40px" OnClick="btnGoBack_Click" Text="Undo" BorderColor="#41719C" />
                    

                        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="auto-style4" Font-Bold="True"></asp:TextBox>
                        <asp:Button ID="btnCancelContrbtnGoBack_act0" runat="server" BackColor="#6FC0D3" CssClass="auto-style1" Font-Bold="True" Height="40px" OnClick="btnCancel_Click" Text="Cancel Your Contract" BorderColor="#41719C" />
                    

                        <asp:TextBox ID="txtContractNo" runat="server" CssClass="auto-style6"></asp:TextBox>
                    

                        <asp:Label ID="lblEnterContractNo" runat="server" CssClass="auto-style7" Font-Bold="True" Text="Enter Contract No"></asp:Label>
                        <asp:Label ID="lblEnterCustomerNo" runat="server" CssClass="auto-style8" Font-Bold="True" Text="Enter Customer No"></asp:Label>
                    

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
