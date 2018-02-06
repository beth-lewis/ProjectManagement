﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHomepage.aspx.cs" Inherits="PhonePal.Staff_Web_Pages.AdminHomepage" %>

<!DOCTYPE html>
<html>
<head>
    <title> Phone Pal Admin </title>

    <!--link to stlesheet-->
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>

<body>
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
            <center>
                
                 <h2> Homepage </h2> 

                    <p> <a href="StaffUpdateDetails.html"> <input id="button" type="submit" value="Update Staff Details" /> </a> </p>
                    <p> <a href="StaffDisplayDetails.html"> <input id="button" type="submit" value="Display Staff " /> </a> </p>
                    <p> <a href="AdminSearchStaff.html"> <input id="button" type="submit" value="Search Staff" /> </a> </p>
                    <p> <a href="StaffAddDetails.html"> <input id="button" type="submit" value="Add Staff Details" /> </a> </p>

            </center>
            <br />
        </div>
        <br />

        <div id="footer">
            <h5> &copy; Phone Pal</h5>
        </div>
    </div>

</body>
</html>

