<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main Page Contract.aspx.cs" Inherits="Contract" %>

<!DOCTYPE html>
<html>
<head>
    <title>Phone Pal - Contracts</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
    <style type="text/css">
        
        
        .auto-style1 {
            height: 613px;
        }
        
        
        .auto-style2 {
            height: 428px;
        }
        
        
        </style>
</head>

<body>
    <form id="frmPhonePal" runat="server">
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
                <center class="auto-style2">
                        <h2>Contracts</h2>
                      <br />
                      

                    
                      <asp:ListBox ID="lstContracts" runat="server" CssClass="auto-style9" Height="250px" Width="283px"></asp:ListBox>
                        
       <br />
                        <br />
                     <asp:Label ID="lblError" runat="server" CssClass="auto-style10" Font-Bold="True"></asp:Label>
                    <br /><br /><br />
                    <asp:Button ID="btnAddAContract" runat="server" BackColor="#6FC0D3" CssClass="button" Font-Bold="True" Height="30px" OnClick="btnAddAContract_Click" Text="Add A Contract" Width="150px" BorderColor="#41719C" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDeleteContract" runat="server" BackColor="#6FC0D3" CssClass="button" Font-Bold="True" Height="30px" OnClick="btnDeleteContract_Click" Text="Delete Contract" Width="150px" BorderColor="#41719C" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnFindAContract" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="button" Font-Bold="True" Height="30px" OnClick="btnFindAContract_Click" Text="Find Contract" Width="150px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnUpgradeContract" runat="server" BackColor="#6FC0D3" CssClass="button" Font-Bold="True" Height="30px" OnClick="btnUpgradeContract_Click" Text="Upgrade Contract" Width="150px" BorderColor="#41719C" />
                    <br /><br />
                       
                       

                    


                    <p class="auto-style7">
                      
                        </p>


                </center>
                <br />
                <br />
                
            </div>

            <div id="footer">
                <h5> &copy; Phone Pal
                </h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>

