<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="hey.aspx.cs" Inherits="Student_hey" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">
     <link href="css/TestStyle.css" rel="stylesheet" />
        <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>
                                
                            </li>

                            <li class="b-inner">
                                <a href="StudentDashboard.aspx"><i class="fa fa-graduation-cap"></i>&nbsp;&nbsp; Students</a>                              
                            </li>
                                
                            <li class="a-inner" > <a href="../Student/addstudent.aspx"><i class="fa fa-caret-square-o-right i-class"></i><span class="inner-span" > Add Student </span></a> </li>
                        
                            <li class="a-inner" > <a><i class="fa fa-caret-square-o-right i-class" ></i><span class="inner-span" > Student Report</span></a> </li>
                            
                                   <li class="a-inner" > <a><i class="fa fa-caret-square-o-right text-right i-class"></i>
                                       <span class="inner-span"> Student</span> </a> </li>

                                   
                                   <li class="a-inner" > <a ><i class="fa fa-caret-square-o-right i-class"></i> <span class="inner-span" > Student Report</span></a> </li>
                            </ul>                              
                        
                    </nav>
                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentbody" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentDisplay" Runat="Server">
</asp:Content>

