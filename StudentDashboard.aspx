<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="StudentDashboard.aspx.cs" Inherits="StudentDashboard" %>

<asp:Content ID="content1" runat="server" ContentPlaceHolderID="contentSide">
    <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>
                                
                            </li>
                            <li>
                                <a class="has-arrow" href="StudentDashboard.aspx"><i class="fa fa-graduation-cap"></i>>&nbsp;&nbsp; Students</a>
                               
                            </li>
                        </ul>
                    </nav>
                </div>
</asp:Content>
<%-- Add content controls here --%>
