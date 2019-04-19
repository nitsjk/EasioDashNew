<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="ViewClass.aspx.cs" Inherits="ViewClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentbody" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentDisplay" Runat="Server">

    <asp:GridView ID="grdView" runat="server">
        <Columns>
            <asp:BoundField HeaderText="Class" DataField="ClassName" />
        </Columns>
    </asp:GridView>
</asp:Content>

