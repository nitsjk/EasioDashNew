<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Imran.aspx.cs" Inherits="Imran" %>

<!DOCTYPE html>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI"%>
<html>
    
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">

</head>
<body>
    <form id="form1" runat="server">
    <div>
       

        <asp:GridView ID="GridView1" runat="server" Width="50%" AllowPaging="true"  OnPageIndexChanging="GridView1_PageIndexChanging" OnRowEditing="GridView1_RowEditing" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="false">
            <Columns>
                 <asp:TemplateField HeaderText="S.NO">
                <ItemTemplate>
                <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                          </asp:TemplateField>
                 <asp:BoundField ItemStyle-Width="150px" DataField="ID" HeaderText="ID" Visible="false" />
                     
                <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Name" />

        <asp:BoundField ItemStyle-Width="150px" DataField="Address" HeaderText="Address" />

        <asp:BoundField ItemStyle-Width="150px" DataField="Phone" HeaderText="Phone" />


              <asp:TemplateField HeaderText="Edit">
                      <ItemTemplate>
                          <asp:LinkButton ID="lklagent" Text="" runat="server"   CommandName="Edit" CommandArgument='<%#Eval("ID") %>' CssClass= "glyphicon glyphicon-edit"></asp:LinkButton>

                          
                      </ItemTemplate>
                     </asp:TemplateField>
            </Columns>

        </asp:GridView>
        <asp:Label ID="Label2" runat="server" Text="Label" style="margin-bottom:20px"> Name</asp:Label>
         <asp:TextBox ID="txtname" runat="server" style="margin-bottom:20px;margin-top:20px; margin-left:23px" ></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text=""> Address</asp:Label>
        <asp:TextBox ID="txtaddress" runat="server" style="margin-bottom:20px; margin-left:18px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="">Phone No</asp:Label>
        <asp:TextBox ID="txtphone" runat="server" ></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Sumit" OnClick="Button1_Click" style="margin-left:80px; margin-top:10px" />
        <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />



    </div>
    </form>
</body>
</html>
