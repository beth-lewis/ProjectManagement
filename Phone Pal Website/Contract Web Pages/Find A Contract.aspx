<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Find A Contract.aspx.cs" Inherits="Cancel_Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">

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

                
                                               

                                          <asp:ListBox ID="lstContractsFiltered" runat="server" CssClass="auto-style9" Height="250px" Width="348px"></asp:ListBox>
                    <br /><br /><br />
                          <asp:Label ID="lblContractType" runat="server" CssClass="auto-style30" Text="Search For Contract Type" Font-Bold="True"></asp:Label>
                    <br /><br />
                    <asp:TextBox ID="txtContractTypeFilter" runat="server" CssClass="auto-style28" Height="16px" Width="230px"></asp:TextBox>
                        <br /><br />
                     <asp:Label ID="lblError" runat="server" CssClass="auto-style10" Font-Bold="True"></asp:Label>
                    <br /><br /><br />
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" CssClass="auto-style12" Font-Bold="True" Height="30px" OnClick="btnGoBack_Click" Text="Go Back" Width="180px" BorderColor="#41719C" />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="btnSearchForContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style11" Font-Bold="True" Height="30px" OnClick="btnSearchForContract_Click" Text="Search For Contract" BorderColor="#41719C" Width="180px" />
                    <br /><br />
                    <asp:Button ID="btnUpgradeContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style11" Font-Bold="True" Height="30px" Text="Upgrade Contract" BorderColor="#41719C" Width="180px" OnClick="btnUpgradeContract_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnDeleteContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style11" Font-Bold="True" Height="30px" Text="Delete Contract" BorderColor="#41719C" Width="180px" OnClick="btnDeleteContract_Click" />
                    

                     
                    

                
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
