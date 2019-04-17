<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Subjects.aspx.cs" Inherits="Subjects" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">
    <style>
    
        ul
        .b {
  list-style-type: square;
}
</style>
    
      <div class="left-custom-menu-adp-wrap comment-scrollbar">
                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu b" id="menu1">
                            <li class="active">
                                <a  href="Default.aspx">
                                    <i class="fa big-icon fa-home icon-wrap"></i>
                                    <span class="mini-click-non">Dashboard</span>
                                </a>                               
                            </li>

                              <li>
                                <a href="Subjects.aspx" aria-expanded="false"><i class="fa fa-book"></i>&nbsp;&nbsp; Subjects</a>
                                
                                  <li style="padding-left:30px;" > 
                                      <a> <i class="fa fa-caret-square-o-right" style="font-size:14px"></i> Add Subject</a>                                     
                            </li>


                        </ul>
                    </nav>
      </div>




</asp:Content>

