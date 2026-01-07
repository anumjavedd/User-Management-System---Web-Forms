<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="PresentationLayerWebb.Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabID" runat="server" Text="Please Select ID:"></asp:Label>
            <asp:DropDownList ID="DDLUsers" runat="server"></asp:DropDownList>
            <asp:Button ID="BtnSearch" runat="server" Text="Search" OnClick="BtnSearch_Click" />
        </div>

       <div>
       <asp:Label ID ="LabFirstName" runat="server" Text="Please Enter First Name:"></asp:Label>
       <asp:TextBox ID ="TxtFirstName" runat="server"></asp:TextBox>
       </div>
       <div>
       <asp:Label ID ="LabLastName" runat="server" Text="Please Enter First Name:"></asp:Label>
       <asp:TextBox ID ="TxtLastName" runat="server"></asp:TextBox>
       </div>
       <div>
       <asp:Label ID ="LabEmail" runat="server" Text="Please Enter Email:"></asp:Label>
       <asp:TextBox ID ="TxtEmail" runat="server"></asp:TextBox>
       </div>
       <div>
       <asp:Label ID ="LabAddress" runat="server" Text="Please Enter Address:"></asp:Label>
       <asp:TextBox ID ="TxtAddress" runat="server"></asp:TextBox>
       </div>
       
       <div>
       <asp:Label ID ="LabAge" runat="server" Text="Please Enter Age:"></asp:Label>
       <asp:TextBox ID ="TxtAge" runat="server"></asp:TextBox>
       </div>
       <div>
       <asp:Label ID ="Label2" runat="server" Text="Please Enter Gender:"></asp:Label>
       <asp:TextBox ID ="TxtGender" runat="server"></asp:TextBox>
       </div>
       <div>
       <asp:Label ID ="Label3" runat="server" Text="Please Enter Country:"></asp:Label>
       <asp:TextBox ID ="TxtCountry" runat="server"></asp:TextBox>
       </div>

          <div>
          <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
          <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
          <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
          <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" />
          </div>
        <div>
            <asp:Label ID="LabResult" runat="server" Text=""></asp:Label>
                </div>
        <div>
            <asp:GridView ID="GVUsers" runat="server"></asp:GridView>
        </div>

    </form>
</body>
</html>
