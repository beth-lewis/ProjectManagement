<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main Page Contract.aspx.cs" Inherits="Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 299px;
            left: 810px;
            z-index: 1;
            height: 40px;
            margin-top: 21px;
        }
        .auto-style2 {
            position: absolute;
            top: 380px;
            left: 990px;
            z-index: 1;
            height: 40px;
        }
        .auto-style3 {
            position: absolute;
            top: 265px;
            left: 990px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 320px;
            left: 990px;
            z-index: 1;
            height: 40px;
            margin-top: 0px;
            bottom: 256px;
        }
        .auto-style5 {
            position: absolute;
            top: 237px;
            left: 330px;
            z-index: 1;
            height: 360px;
            width: 435px;
            margin-top: 13px;
        }
        .auto-style6 {
            height: 666px;
        }
        .auto-style7 {
            height: 173px;
        }
        .auto-style8 {
            position: absolute;
            left: 810px;
            z-index: 1;
            top: 395px;
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
                <center class="auto-style6">


                        <h2>Contracts<asp:Button ID="btnFindAContract" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="auto-style8" Font-Bold="True" Height="40px" OnClick="btnFindAContract_Click" Text="Find Contract" Width="133px" />
                        </h2>


                    <p class="auto-style7">
                        &nbsp;</p>


                </center>
                <br />
                <br />
                <asp:Button ID="btnCancelContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style2" Font-Bold="True" Height="40px" OnClick="btnCancelContract_Click" Text="Cancel Contract" Width="133px" BorderColor="#41719C" />
                <asp:TextBox ID="txtBxContract" runat="server" CssClass="auto-style5"></asp:TextBox>
                
            </div>

            <div id="footer">
                <h5> &copy; Phone Pal<asp:Button ID="btnViewContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style1" Font-Bold="True" Height="40px" OnClick="btnViewContract_Click" Text="View Contract" Width="133px" BorderColor="#41719C" />
                    <asp:Button ID="btnAddAContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style4" Font-Bold="True" Height="40px" OnClick="btnAddAContract_Click" Text="Add A Contract" Width="133px" BorderColor="#41719C" />
                    <asp:Button ID="btnUpgradeContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style3" Font-Bold="True" Height="40px" OnClick="btnUpgradeContract_Click" Text="Upgrade Contract" Width="133px" BorderColor="#41719C" />
                </h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>

