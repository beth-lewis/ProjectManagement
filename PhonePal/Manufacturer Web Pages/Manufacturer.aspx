<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manufacturer.aspx.cs" Inherits="Manufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Phone Pal - Manufacturers</title>
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
                        <h2>Manufacturers</h2>
                   

                    <br /><br />

                                <select name="txtManufacturers" multiple="multiple" style="width:400px" size="10">
                                    <option>Apple</option>
                                    <option>Samsung</option>
                                    <option>Lenovo</option>
                                    <option>Google</option>
                                    <option>Nokia</option>
                                </select>
                    <br /><br/>
                    Filter by Name:<input id="txtFilter" type="text"/> <input id="btnFilter" type="button" value="Filter" />
                    <br /> <br />

                                <a href="Contract.html"><input id="btnViewContracts" type="submit" value="View Contracts" /></a>
                                <br /><br />

                                <a href="AddManufacturer.aspx"><input id="btnAddManufacturer" type="submit" value="Add Manufacturer" /></a>

                                <a href="EditManufacturer.aspx"><input id="btnEditManufacturer" type="submit" value="Edit Manufacturer" /></a>

                                <input id="btnDeleteMAnufacturer" type="button" value="Delete Manufacturer" />


                    <br />
              </center>
            </div>
        </div>
            <div id="footer">
                <h5> &copy; Phone Pal</h5>
            </div>
        </div>
    

</body>
</html>
