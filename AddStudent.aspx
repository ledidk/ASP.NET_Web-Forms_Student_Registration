﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Lab8.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title>Students</title>
    <link type="text/css" href="Theme/SiteStyle.css" rel="stylesheet"/>
</head>



<body>
    <form id="form1" runat="server">
       
            <h1 >Students</h1>
       
        <div>
           <div id="divStudentInfo">

        <p> Student Name: <asp:TextBox runat="server" ID="lblStudentName" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvExperience" runat="server" ControlToValidate="lblStudentName"
                ForeColor="Red" ToolTip="Please enter your experience" Display="Dynamic">Can not be blank!</asp:RequiredFieldValidator></p>

              <p> Student Type: <asp:DropdownList ID="drpType" runat="server"> 
            <asp:ListItem Value ="-1" Text="Select ..."></asp:ListItem> 
            <asp:ListItem Value ="0" Text="Full Time"></asp:ListItem> 
            <asp:ListItem Value ="1" Text="Part Time"></asp:ListItem> 
            <asp:ListItem Value ="2" Text="Coop"></asp:ListItem> 
        </asp:DropdownList>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="-1" ControlToValidate="drpType"
                ForeColor="Red" ToolTip="Please enter your experience" Display="Dynamic">select one plz!</asp:RequiredFieldValidator></p>


           </div>

       <div id="divbtnAdd"><asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="btn_Add" /></div> 


            <div id="divTable">

                 <asp:Table ID="tblStudents" runat="server" CssClass="table"> 
             <asp:TableHeaderRow>
            <asp:TableHeaderCell>Code</asp:TableHeaderCell>
            <asp:TableHeaderCell>Title</asp:TableHeaderCell>
           </asp:TableHeaderRow>
          </asp:Table>


            </div>
       
        </div>

        
    </form>
    <a href="/RegisterCourse.aspx" >RegisterCourse</a>
</body>
</html>
