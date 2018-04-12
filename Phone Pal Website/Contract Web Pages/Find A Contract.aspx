<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Find A Contract.aspx.cs" Inherits="Cancel_Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">

        .auto-style2 {
            height: 364px;
        }
        .auto-style7 {
            position: absolute;
            top: 330px;
            left: 520px;
            z-index: 1;
            bottom: 142px;
        }
        .auto-style9 {
            position: absolute;
            top: 330px;
            left: 665px;
            z-index: 1;
        }
        .auto-style10 {
            height: 311px;
        }
        .auto-style11 {
            position: absolute;
            top: 434px;
            left: 520px;
            z-index: 1;
            height: 40px;
            margin-top: 21px;
            width: 190px;
            bottom: 218px;
            right: 825px;
        }
        .auto-style12 {
            position: absolute;
            top: 434px;
            left: 745px;
            z-index: 1;
            height: 40px;
            margin-top: 21px;
            right: 600px;
            bottom: 218px;
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
            <div id="main" class="auto-style10">
                
                <center>
                        <h2>Find A Contract</h2>

                
                                                <asp:Button ID="btnSearchForContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style11" Font-Bold="True" Height="30px" OnClick="btnSearchForContract_Click" Text="Search For Contract" BorderColor="#41719C" Width="140px" />

                    <p class="auto-style2">
                    
                         <asp:Label ID="lblContractType" runat="server" CssClass="auto-style7" Font-Bold="True" Text="Contract Type"></asp:Label>

                        <asp:Button ID="Button2" runat="server" BackColor="#6FC0D3" CssClass="auto-style12" Font-Bold="True" Height="30px" OnClick="btnGoBack_Click" Text="Go Back" Width="140px" BorderColor="#41719C" />
                    
                    

                        <asp:DropDownList ID="ddlContractType" runat="server" AutoPostBack="True" CssClass="auto-style9">
                            <asp:ListItem Value="1">Monthly</asp:ListItem>
                            <asp:ListItem>Pay As You Go</asp:ListItem>
                            <asp:ListItem>Sim Free</asp:ListItem>
                            <asp:ListItem>Sim Only</asp:ListItem>
                        </asp:DropDownList>
                    

                
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
