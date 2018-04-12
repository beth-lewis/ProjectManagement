<%@ Page Language="C#" AutoEventWireup="true" CodeFile="A Contract.aspx.cs" Inherits="A_Contract" %>

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
            <div id="main">
                <center>


                        <h2>A Contract</h2>



               


                    <p class="auto-style1">
                      


                      
                       
                <br />
                                      
                        <asp:Label ID="lblPricePerMonth" runat="server" CssClass="auto-style13" Font-Bold="True" Text="Price Per Month"></asp:Label> <%--label for Price Per Month--%>
                        <br />
                          <asp:TextBox ID="txtPricePerMonth" runat="server" CssClass="auto-style4" Font-Bold="False" TextMode="Number" Height="16px" Width="155px"></asp:TextBox> 
                        <br /><br />
                                                <asp:Label ID="lblNumberOfMinutes" runat="server" CssClass="auto-style18" Font-Bold="True" Text="Number Of Minutes"></asp:Label>
                        
                        <br />
                       
                                <asp:TextBox ID="txtNumberOfMins" runat="server" CssClass="auto-style35" Height="16px" Width="155px"></asp:TextBox>
                        <%--Textbox for Price Per Month--%>
                       
                        
                                <br />
                         
                        <br />
                        <asp:Label ID="lblDataAllowance" runat="server" CssClass="auto-style17" Font-Bold="True" Text="Data Allowance"></asp:Label> <%--label for Data Allowance--%>
                        <br />
                        <asp:TextBox ID="txtDataAllowance" runat="server" CssClass="auto-style34" Height="16px" Width="155px"></asp:TextBox><%-- Textbox for Data Allowance--%>

                           <br />
                        <br />
                        <asp:Label ID="lblDuration" runat="server" CssClass="auto-style20" Font-Bold="True" Text="Duration"></asp:Label>
                        <br />
                                                <asp:TextBox ID="txtDuration" runat="server" CssClass="auto-style33" Height="16px" Width="155px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblContractType" runat="server" CssClass="auto-style16" Font-Bold="True" Text="Contract Type"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtContractType" runat="server" CssClass="auto-style32" Height="16px" Width="155px"></asp:TextBox>

                
                        <br />
                        <br />
                        <asp:Label ID="lblNumberOfTexts" runat="server" CssClass="auto-style19" Font-Bold="True" Text="Number Of Texts"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtNumberOfTexts" runat="server" CssClass="auto-style36" Height="16px" Width="155px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblStaffNo" runat="server" CssClass="auto-style27" Text="Staff No" Font-Bold="True"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtStaffNo" runat="server" CssClass="auto-style26" Height="16px" Width="155px"></asp:TextBox>
                        
                <br /><br />
                        <asp:Label ID="lblCustomerNo" runat="server" CssClass="auto-style31" Text="CustomerNo" Font-Bold="True"></asp:Label>
                        
                <br />
                        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="auto-style29" Height="16px" Width="155px"></asp:TextBox>
                        
                <br /><br />
                        <asp:Label ID="lblManufacturerNo" runat="server" CssClass="auto-style30" Text="Manufacturer No" Font-Bold="True"></asp:Label>

                        <br />                
                        <asp:TextBox ID="txtManufacturerNo" runat="server" CssClass="auto-style28" Height="16px" Width="155px"></asp:TextBox>
                        
                                        
                        <br />
                        <br />
                        <asp:Label ID="lblError" runat="server" CssClass="auto-style25"></asp:Label>
                        <br /><br />
                        <asp:Button ID="btnSave" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="buttons" Text="Save" OnClick="btnSave_Click" Font-Bold="True" Width="100px" Height="30px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnGoBack" runat="server" BackColor="#6FC0D3" BorderColor="#41719C" CssClass="button" Text="Go Back" OnClick="btnGoBack_Click" Font-Bold="True" Height="30px" Width="100px" />
                             </center>
                                                                
                       
            </div>

            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    </div>

    </form>

</body>
</html>

