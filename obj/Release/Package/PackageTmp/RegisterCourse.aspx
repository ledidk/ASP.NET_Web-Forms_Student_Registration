<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCourse.aspx.cs" Inherits="Lab8.RegisterCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrations</title>
    <link type="text/css" href="Theme/SiteStyle.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="alignform">

              <h1>Registration</h1>

            <p>Student:        <asp:DropDownList ID="drplst" runat="server" OnSelectedIndexChanged="drplst_SelectedIndexChanged">
                <asp:ListItem Value="-1" Text="Select ..."></asp:ListItem>
            </asp:DropDownList>
      
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="-1" ControlToValidate="drplst"
                ForeColor="Red" ToolTip="Please enter your experience" Display="Dynamic">Must select one!</asp:RequiredFieldValidator></p>
           
        </div>
          <h4><asp:Label runat="server" ID="lblResultMsg" CssClass="alert-danger" Visible="false"/></h4>
        <asp:Panel runat="server" ID="form1_chklst" Visible="true">
           
            <div>     <h4><asp:Label runat="server" ID="lblResult" CssClass="alert-great" Visible="false"/></h4></div>

            <h3>Following Courses are currently available for registration</h3> 
      
             <h4><asp:Label runat="server" ID="lblErrorMsg" CssClass="alert-danger" Visible="false"/></h4>

            <asp:CheckBoxList ID="chklst" runat="server" />

             <div><asp:Button ID="submit" Text="Save" runat="server" OnClick="cmd_submit" /></div>

            <br /><br />
        </asp:Panel>
    </form>

    <a href="/AddStudent.aspx" >AddStudent</a>
</body>
</html>
