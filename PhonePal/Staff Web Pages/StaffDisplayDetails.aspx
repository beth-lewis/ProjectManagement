<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDisplayDetails.aspx.cs" Inherits="StaffDisplayDetails" %>

<!DOCTYPE html>
<html>
<head>

    <title>Phone Pal</title>

    <!--link to stlesheet-->
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
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
        <div id="main">
            
            <h3> Add Staff Details </h3>

            <asp:ListBox ID="lstStaff" runat="server" Height="238px" Width="361px"></asp:ListBox>
            
            <br />
            
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />

        </div>
        <br />
        <div id="footer">
            <h5> &copy; Phone Pal</h5>
        </div>
    </div>

    </form>

</body>
</html>

