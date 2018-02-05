<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Find A Contract.aspx.cs" Inherits="Find_A_Contract" %>

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
            right: 775px;
        }
        .auto-style2 {
            height: 529px;
        }
        .auto-style3 {
            position: absolute;
            top: 614px;
            left: 755px;
            z-index: 1;
            height: 40px;
            margin-top: 21px;
            right: 597px;
            bottom: 175px;
        }
        .auto-style7 {
            position: absolute;
            top: 330px;
            left: 520px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 375px;
            left: 515px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 330px;
            left: 665px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 375px;
            left: 665px;
            z-index: 1;
            width: 112px;
            height: 19px;
        }
        .auto-style11 {
            position: absolute;
            top: 420px;
            left: 510px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 420px;
            left: 665px;
            z-index: 1;
            width: 102px;
            height: 21px;
        }
        .auto-style13 {
            position: absolute;
            top: 465px;
            left: 510px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 470px;
            left: 670px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 510px;
            left: 515px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 510px;
            left: 665px;
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


                        <h2>Find Contract</h2>


                    <p class="auto-style2">
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" CssClass="auto-style3" Font-Bold="True" Height="40px" OnClick="btnGoBack_Click" Text="Go Back" Width="133px" BorderColor="#41719C" />
                    

                        <asp:Label ID="lblContractType" runat="server" CssClass="auto-style7" Font-Bold="True" Text="Contract Type"></asp:Label>
                        <asp:Button ID="btnSearchForContract" runat="server" BackColor="#6FC0D3" CssClass="auto-style1" Font-Bold="True" Height="40px" OnClick="btnSearchForContract_Click" Text="Search For Contract" BorderColor="#41719C" />
                    

                        <asp:Label ID="lblDuration" runat="server" CssClass="auto-style8" Font-Bold="True" Text="Duration"></asp:Label>
                        <asp:Label ID="lblDataAllowance" runat="server" CssClass="auto-style11" Font-Bold="True" Text="Data Allowance"></asp:Label>
                        <asp:DropDownList ID="ddlContractType" runat="server" AutoPostBack="True" CssClass="auto-style9">
                            <asp:ListItem Value="1">Monthly</asp:ListItem>
                            <asp:ListItem>Pay As You Go</asp:ListItem>
                            <asp:ListItem>Sim Free</asp:ListItem>
                            <asp:ListItem>Sim Only</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlDuration" runat="server" CssClass="auto-style10">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>3 Months</asp:ListItem>
                            <asp:ListItem>6 Months</asp:ListItem>
                            <asp:ListItem>1 Year</asp:ListItem>
                            <asp:ListItem>2 Years</asp:ListItem>
                            <asp:ListItem>3 Years</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlDataAllowance" runat="server" CssClass="auto-style12" Height="25px">
                            <asp:ListItem>500MB</asp:ListItem>
                            <asp:ListItem>1GB</asp:ListItem>
                            <asp:ListItem>2GB</asp:ListItem>
                            <asp:ListItem>3GB</asp:ListItem>
                            <asp:ListItem>4GB</asp:ListItem>
                            <asp:ListItem>5GB+</asp:ListItem>
                            <asp:ListItem>Unlimited</asp:ListItem>
                        </asp:DropDownList>
                    

                        <asp:Label ID="lblNumberOfMinutes" runat="server" CssClass="auto-style13" Font-Bold="True" Text="Number of Minutes"></asp:Label>
                        <asp:Label ID="lblNumberOfTexts" runat="server" CssClass="auto-style15" Font-Bold="True" Text="Number Of Texts"></asp:Label>
                        <asp:DropDownList ID="ddlNumberOfTexts" runat="server" CssClass="auto-style16">
                            <asp:ListItem>1000 Texts</asp:ListItem>
                            <asp:ListItem>2000 Texts</asp:ListItem>
                            <asp:ListItem>3000 Texts</asp:ListItem>
                            <asp:ListItem>4000 Texts</asp:ListItem>
                            <asp:ListItem>5000 Texts+</asp:ListItem>
                            <asp:ListItem>Unlimited</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlNumberOfMins" runat="server" CssClass="auto-style14">
                            <asp:ListItem>100 Mins</asp:ListItem>
                            <asp:ListItem>200 Mins</asp:ListItem>
                            <asp:ListItem>300 Mins</asp:ListItem>
                            <asp:ListItem>400 Mins</asp:ListItem>
                            <asp:ListItem>500 Mins+</asp:ListItem>
                            <asp:ListItem>Unlimited</asp:ListItem>
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
