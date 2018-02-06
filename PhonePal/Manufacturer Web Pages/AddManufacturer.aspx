﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddManufacturer.aspx.cs" Inherits="AddManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Phone Pal</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css" /><!--link to stlesheet-->
</head>

<body>
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
                        <td><a href="Home.aspx"><ins>Home</ins></a></td>
                        <td><a href="Manufacturer.aspx"><ins>Manufacturers</ins></a></td>
                        <td><a href="Accessories.aspx"><ins>Accessories</ins></a></td>
                        <td><a href="Contract.aspx"><ins>Contracts</ins></a></td>
                        <td><a href="Customer.aspx"><ins>Customer</ins></a></td>
                        <td><a href="Staff.aspx"><ins>Staff</ins></a></td>
                    </tr>
                </table>

            </div>
            <div id="main">
              <center>


                    
                        <h2>Add Manufacturer</h2>
                    
                    <table>
                        <tr>
                            <td>
                                ManufacturerNo:
                            </td>
                            <td>
                                <input id="txtManufacturerNo" type="text" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Name:
                            </td>
                            <td>
                                <input id="txtManufacturerName" type="text" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Location:
                            </td>
                            <td>
                                <input id="txtManufacturerLocation" type="text" /> 
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Year Started:
                            </td>
                            <td>
                                <input id="txtYearStarted" type="text" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Email:
                            </td>
                            <td>
                                <input id="txtEmail" type="text" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Telephone:
                            </td>
                            <td>
                                <input id="txtTelephone" type="text" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Active?:
                            </td>
                            <td>
                                <input id="chkActive" type="checkbox" />
                            </td>
                        </tr>
                    </table>
                    <br/>
                    <input id="btnAddManufacturer" type="button" value="Add Manufacturer" />
                    <a href="Manufacturer.aspx"><input id="btnBack" type="submit" value="Back" /> </a>
                </center>
                <br />

            </div>

            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    </div>

</body>
</html>
