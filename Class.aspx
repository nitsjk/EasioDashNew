<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="Class.aspx.cs" Inherits="_Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">
    <%--<div class="sidebar-header">--%>
                   <%-- <a href="Default.aspx">         
                            
                        <div><img  src="img/easio-logo2.png" height="110px" width="130px" /></div>

                        </a>           
                                 

                </div>--%>
     <link href="css/TestStyle.css" rel="stylesheet" />esheet" />
      <div class="left-custom-menu-adp-wrap comment-scrollbar">

          
                        <div>
                           <a href="../Default.aspx">  <img  src="../img/easio-logo2.png" height="110px" width="130px" style="margin-left:25px" /> </a>
                        </div>

                        

                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">
                            
                           <li class="b-inner">
                                <a href="Class.aspx" aria-expanded="false" ><i class="fa fa-university"></i><span class="mini-click-non">&nbsp;&nbsp; Class</span></a>                               
                            </li>

                            
                            
                                   <li class="a-inner" style="display:table-row"> <a href="Class/ManageClasses.aspx" class="a-inner-middle" style="display:table-cell;
   vertical-align:middle;"> <i class="fa fa-caret-square-o-right" style="font-size:14px"></i> <span class="inner-span"> Manage Classes </span></a> </li>

                                          <li class="a-inner" style="display:table-row"> <a href="Class/ManageSections.aspx" class="a-inner-middle" style="display:table-cell;
   vertical-align:middle;"> <i class="fa fa-caret-square-o-right" style="font-size:14px"></i> <span class="inner-span"> Manage Sections </span></a> </li>

                                   
                                   



                            </ul>
                     </nav>
      </div>
</asp:Content>

<asp:Content ID="contenthead" runat="server" ContentPlaceHolderID="contentbody">
    <div class="header-advance-area">
                <div class="header-top-area">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                
                                <div class="header-top-wraper">
                                    <div class="row">
                                        <div class="col-lg-1 col-md-0 col-sm-1 col-xs-12">
                                            <div class="menu-switcher-pro">
                                                <button type="button" id="sidebarCollapse" class="btn bar-button-pro header-drl-controller-btn btn-info navbar-btn">
                                                    <i class="fa fa-bars"></i>
                                                </button>
                                            </div>
                                        </div>
                                        <div class="col-lg-5 col-md-6 col-sm-6 col-xs-12">
                                            <div class="header-top-menu tabl-d-n">
                                                <ul class="nav navbar-nav mai-top-nav">
                                                    <li class="nav-item"><a href="#" class="nav-link">Home</a>
                                                    </li>
                                                    <li class="nav-item"><a href="#" class="nav-link">About</a>
                                                    </li>
                                                    <li class="nav-item"><a href="#" class="nav-link">Services</a>
                                                    </li>
                                                    <li class="nav-item"><a href="#" class="nav-link">Support</a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                                            <div class="header-right-info">
                                                <ul class="nav navbar-nav mai-top-nav header-right-menu">

                                                    <li class="nav-item">
                                                        <span style="color: white" class="h4">[<asp:Label ID="lblSession" runat="server" Text="Session"></asp:Label>]</span>
                                                    </li>

                                                    <li class="nav-item">
                                                        <span style="color: white" class="h4">[<asp:Label ID="lblfinancialyear" runat="server" Text="Financial Year"></asp:Label>]</span>
                                                    </li>

                                                    <li class="nav-item dropdown">
                                                        <a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle"><i class="fa fa-envelope-o adminpro-chat-pro" aria-hidden="true"></i><span class="indicator-ms"></span></a>
                                                        <div role="menu" class="author-message-top dropdown-menu animated zoomIn">
                                                            <div class="message-single-top">
                                                                <h1>Message</h1>
                                                            </div>
                                                            <ul class="message-menu">

                                                                <li>
                                                                    <a href="#">
                                                                        <div class="message-img">
                                                                            <img src="img/human-6.png" alt="">
                                                                        </div>
                                                                        <div class="message-content">
                                                                            <span class="message-date">16 Sept</span>
                                                                            <h2>Sulaiman din</h2>
                                                                            <p>Please done this project as soon possible.</p>
                                                                        </div>
                                                                    </a>
                                                                    <li></li>
                                                                    <a href="#">
                                                                        <div class="message-img">
                                                                            <img src="img/human-4.png" alt="">
                                                                        </div>
                                                                        <div class="message-content">
                                                                            <span class="message-date">16 Sept</span>
                                                                            <h2>Victor Jara</h2>
                                                                            <p>Please done this project as soon possible.</p>
                                                                        </div>
                                                                    </a>
                                                                </li>
                                                                <li>
                                                                    <a href="#">
                                                                        <div class="message-img">
                                                                            <img src="img/human-6.png" alt="">
                                                                        </div>
                                                                        <div class="message-content">
                                                                            <span class="message-date">16 Sept</span>
                                                                            <h2>Victor Jara</h2>
                                                                            <p>Please done this project as soon possible.</p>
                                                                        </div>
                                                                    </a>
                                                                </li>
                                                            </ul>
                                                            <div class="message-view">
                                                                <a href="#">View All Messages</a>
                                                            </div>
                                                        </div>
                                                    </li>
                                                    <li class="nav-item"><a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle"><i class="fa fa-bell-o" aria-hidden="true"></i><span class="indicator-nt"></span></a>
                                                        <div role="menu" class="notification-author dropdown-menu animated zoomIn">
                                                            <div class="notification-single-top">
                                                                <h1>Notifications</h1>
                                                            </div>
                                                            <ul class="notification-menu">
                                                                <li>
                                                                    <a href="#">
                                                                        <div class="notification-icon">
                                                                            <i class="fa fa-check adminpro-checked-pro admin-check-pro" aria-hidden="true"></i>
                                                                        </div>
                                                                        <div class="notification-content">
                                                                            <span class="notification-date">16 Sept</span>
                                                                            <h2>Advanda Cro</h2>
                                                                            <p>Please done this project as soon possible.</p>
                                                                        </div>
                                                                    </a>
                                                                </li>
                                                                <li>
                                                                    <a href="#">
                                                                        <div class="notification-icon">
                                                                            <i class="fa fa-cloud adminpro-cloud-computing-down" aria-hidden="true"></i>
                                                                        </div>
                                                                        <div class="notification-content">
                                                                            <span class="notification-date">16 Sept</span>
                                                                            <h2>Sulaiman din</h2>
                                                                            <p>Please done this project as soon possible.</p>
                                                                        </div>
                                                                    </a>
                                                                </li>
                                                                <li>
                                                                    <a href="#">
                                                                        <div class="notification-icon">
                                                                            <i class="fa fa-eraser adminpro-shield" aria-hidden="true"></i>
                                                                        </div>
                                                                        <div class="notification-content">
                                                                            <span class="notification-date">16 Sept</span>
                                                                            <h2>Victor Jara</h2>
                                                                            <p>Please done this project as soon possible.</p>
                                                                        </div>
                                                                    </a>
                                                                </li>
                                                                <li>
                                                                    <a href="#">
                                                                        <div class="notification-icon">
                                                                            <i class="fa fa-line-chart adminpro-analytics-arrow" aria-hidden="true"></i>
                                                                        </div>
                                                                        <div class="notification-content">
                                                                            <span class="notification-date">16 Sept</span>
                                                                            <h2>Victor Jara</h2>
                                                                            <p>Please done this project as soon possible.</p>
                                                                        </div>
                                                                    </a>
                                                                </li>
                                                            </ul>
                                                            <div class="notification-view">
                                                                <a href="#">View All Notification</a>
                                                            </div>
                                                        </div>
                                                    </li>
                                                    <li class="nav-item">
                                                        <a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle">
                                                            <i class="fa fa-user adminpro-user-rounded header-riht-inf" aria-hidden="true"></i>
                                                            <span class="admin-name">Admin Name</span>
                                                            <i class="fa fa-angle-down adminpro-icon adminpro-down-arrow"></i>
                                                        </a>
                                                        <ul role="menu" class="dropdown-header-top author-log dropdown-menu animated zoomIn">
                                                            <%--<li><a href="#"><span class="fa fa-home author-log-ic"></span>Register</a>
                                                        </li>--%>
                                                            <li><a href="#"><span class="fa fa-user author-log-ic"></span>My Profile</a>
                                                            </li>
                                                            <%--<li><a href="#"><span class="fa fa-diamond author-log-ic"></span> Lock</a>
                                                        </li>--%>
                                                            <li><a href="#"><span class="fa fa-cog author-log-ic"></span>Settings</a>
                                                            </li>
                                                            <li><a href="#"><span class="fa fa-lock author-log-ic"></span>Log Out</a>
                                                            </li>
                                                        </ul>
                                                    </li>
                                                    <li class="nav-item nav-setting-open"><a href="#" data-toggle="dropdown" role="button" aria-expanded="false" class="nav-link dropdown-toggle"><i class="fa fa-tasks"></i></a>

                                                        <div role="menu" class="admintab-wrap menu-setting-wrap menu-setting-wrap-bg dropdown-menu animated zoomIn">
                                                            <ul class="nav nav-tabs custon-set-tab">
                                                                <%--<li class="active"><a data-toggle="tab" href="#Notes">News</a>
                                                            </li>--%>
                                                                <li class="active"><a data-toggle="tab" href="#Projects">Activity</a>
                                                                </li>
                                                                <li><a data-toggle="tab" href="#Settings">Settings</a>
                                                                </li>
                                                            </ul>

                                                            <div class="tab-content custom-bdr-nt">
                                                                <%--<div id="Notes" class="tab-pane fade in active">
                                                                <div class="notes-area-wrap">
                                                                    <div class="note-heading-indicate">
                                                                        <h2><i class="fa fa-comments-o"></i> Latest News</h2>
                                                                        <p>You have 10 New News.</p>
                                                                    </div>
                                                                    <div class="notes-list-area notes-menu-scrollbar">
                                                                        <ul class="notes-menu-list">
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/4.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/1.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/2.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/3.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/4.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/1.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/2.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/1.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/2.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                            <li>
                                                                                <a href="#">
                                                                                    <div class="notes-list-flow">
                                                                                        <div class="notes-img">
                                                                                            <img src="img/contact/3.jpg" alt="" />
                                                                                        </div>
                                                                                        <div class="notes-content">
                                                                                            <p> The point of using Lorem Ipsum is that it has a more-or-less normal.</p>
                                                                                            <span>Yesterday 2:45 pm</span>
                                                                                        </div>
                                                                                    </div>
                                                                                </a>
                                                                            </li>
                                                                        </ul>
                                                                    </div>
                                                                </div>
                                                            </div>--%>
                                                                <div id="Projects" class="tab-pane fade in active">
                                                                    <div class="projects-settings-wrap">
                                                                        <div class="note-heading-indicate">
                                                                            <h2><i class="fa fa-cube"></i>Recent Activity</h2>
                                                                            <p>You have 20 Recent Activity.</p>
                                                                        </div>
                                                                        <div class="project-st-list-area project-st-menu-scrollbar">
                                                                            <ul class="projects-st-menu-list">
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New User Registered</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">1 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New Order Received</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">2 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New Order Received</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">3 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New Order Received</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">4 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New User Registered</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">5 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New Order</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">6 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New User</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">7 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                                <li>
                                                                                    <a href="#">
                                                                                        <div class="project-list-flow">
                                                                                            <div class="projects-st-heading">
                                                                                                <h2>New Order</h2>
                                                                                                <p>The point of using Lorem Ipsum is that it has a more or less normal.</p>
                                                                                                <span class="project-st-time">9 hours ago</span>
                                                                                            </div>
                                                                                        </div>
                                                                                    </a>
                                                                                </li>
                                                                            </ul>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div id="Settings" class="tab-pane fade">
                                                                    <div class="setting-panel-area">
                                                                        <div class="note-heading-indicate">
                                                                            <h2><i class="fa fa-gears"></i>Settings Panel</h2>
                                                                            <p>You have 20 Settings. 5 not completed.</p>
                                                                        </div>
                                                                        <ul class="setting-panel-list">
                                                                            <li>
                                                                                <div class="checkbox-setting-pro">
                                                                                    <div class="checkbox-title-pro">
                                                                                        <h2>Show notifications</h2>
                                                                                        <div class="ts-custom-check">
                                                                                            <div class="onoffswitch">
                                                                                                <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example">
                                                                                                <label class="onoffswitch-label" for="example">
                                                                                                    <span class="onoffswitch-inner"></span>
                                                                                                    <span class="onoffswitch-switch"></span>
                                                                                                </label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </li>
                                                                            <li>
                                                                                <div class="checkbox-setting-pro">
                                                                                    <div class="checkbox-title-pro">
                                                                                        <h2>Disable Chat</h2>
                                                                                        <div class="ts-custom-check">
                                                                                            <div class="onoffswitch">
                                                                                                <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example3">
                                                                                                <label class="onoffswitch-label" for="example3">
                                                                                                    <span class="onoffswitch-inner"></span>
                                                                                                    <span class="onoffswitch-switch"></span>
                                                                                                </label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </li>
                                                                            <li>
                                                                                <div class="checkbox-setting-pro">
                                                                                    <div class="checkbox-title-pro">
                                                                                        <h2>Enable history</h2>
                                                                                        <div class="ts-custom-check">
                                                                                            <div class="onoffswitch">
                                                                                                <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example4">
                                                                                                <label class="onoffswitch-label" for="example4">
                                                                                                    <span class="onoffswitch-inner"></span>
                                                                                                    <span class="onoffswitch-switch"></span>
                                                                                                </label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </li>
                                                                            <li>
                                                                                <div class="checkbox-setting-pro">
                                                                                    <div class="checkbox-title-pro">
                                                                                        <h2>Show charts</h2>
                                                                                        <div class="ts-custom-check">
                                                                                            <div class="onoffswitch">
                                                                                                <input type="checkbox" name="collapsemenu" class="onoffswitch-checkbox" id="example7">
                                                                                                <label class="onoffswitch-label" for="example7">
                                                                                                    <span class="onoffswitch-inner"></span>
                                                                                                    <span class="onoffswitch-switch"></span>
                                                                                                </label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </li>
                                                                            <li>
                                                                                <div class="checkbox-setting-pro">
                                                                                    <div class="checkbox-title-pro">
                                                                                        <h2>Update everyday</h2>
                                                                                        <div class="ts-custom-check">
                                                                                            <div class="onoffswitch">
                                                                                                <input type="checkbox" name="collapsemenu" checked="" class="onoffswitch-checkbox" id="example2">
                                                                                                <label class="onoffswitch-label" for="example2">
                                                                                                    <span class="onoffswitch-inner"></span>
                                                                                                    <span class="onoffswitch-switch"></span>
                                                                                                </label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </li>
                                                                            <li>
                                                                                <div class="checkbox-setting-pro">
                                                                                    <div class="checkbox-title-pro">
                                                                                        <h2>Global search</h2>
                                                                                        <div class="ts-custom-check">
                                                                                            <div class="onoffswitch">
                                                                                                <input type="checkbox" name="collapsemenu" checked="" class="onoffswitch-checkbox" id="example6">
                                                                                                <label class="onoffswitch-label" for="example6">
                                                                                                    <span class="onoffswitch-inner"></span>
                                                                                                    <span class="onoffswitch-switch"></span>
                                                                                                </label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </li>
                                                                            <li>
                                                                                <div class="checkbox-setting-pro">
                                                                                    <div class="checkbox-title-pro">
                                                                                        <h2>Offline users</h2>
                                                                                        <div class="ts-custom-check">
                                                                                            <div class="onoffswitch">
                                                                                                <input type="checkbox" name="collapsemenu" checked="" class="onoffswitch-checkbox" id="example5">
                                                                                                <label class="onoffswitch-label" for="example5">
                                                                                                    <span class="onoffswitch-inner"></span>
                                                                                                    <span class="onoffswitch-switch"></span>
                                                                                                </label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </li>
                                                                        </ul>

                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Mobile Menu start -->
                <div class="mobile-menu-area">
                    <div class="container">
                        <div class="row">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <div class="mobile-menu">
                                    <nav id="dropdown">
                                        <ul class="mobile-menu-nav">
                                            <li><a data-toggle="collapse" data-target="#Charts" href="Default.aspx">Dashboard <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <%--<ul class="collapse dropdown-header-top">
                                                    <li><a href="#">Dashboard v.1</a></li>
                                                    <li><a href="#">Dashboard v.2</a></li>
                                                    <li><a href="#">Dashboard v.3</a></li>
                                                    <li><a href="#">Product List</a></li>
                                                    <li><a href="#">Product Edit</a></li>
                                                    <li><a href="#">Product Detail</a></li>
                                                    <li><a href="#">Product Cart</a></li>
                                                    <li><a href="#">Product Payment</a></li>
                                                    <li><a href="#">Analytics</a></li>
                                                    <li><a href="#">Widgets</a></li>
                                                </ul>--%>
                                            </li>
                                            <li><a data-toggle="collapse" data-target="#demo" href="StudentDashboard.aspx">Students <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="demo" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Student</a>
                                                    </li>
                                                    <li><a href="#">View Student</a>
                                                    </li>
                                                    <li><a href="#">Delete Student</a>
                                                    </li>
                                                </ul>
                                            </li>
                                            <li><a data-toggle="collapse" data-target="#others" href="Class.aspx">Class <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="others" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Class</a></li>
                                                    <li><a href="#">View Class</a></li>
                                                    <li><a href="#">Delete Class</a></li>
                                                </ul>
                                            </li>


                                            <li><a data-toggle="collapse" data-target="#Miscellaneousmob" href="Subjects.aspx">Subjects<span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="Miscellaneousmob" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Subject</a>
                                                    </li>
                                                    <li><a href="#">Delete Subject</a>
                                                    </li>
                                                    <li><a href="#">View Subject</a>
                                                    </li>
                                                  </ul>
                                            </li>
                                            

                                            <li><a data-toggle="collapse" data-target="#Tablesmob" href="Result.aspx">Results <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="Tablesmob" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Result</a>
                                                    </li>
                                                    <li><a href="#">View Result</a>
                                                    </li>
                                                </ul>
                                            </li>

                                            <li><a data-toggle="collapse" data-target="#formsmob" href="Attendence.aspx">Attendence <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="formsmob" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Attedence</a>
                                                    </li>
                                                    <li><a href="#">View Attedence</a>
                                                    </li>
 
                                                </ul>
                                            </li>

                                            <li><a data-toggle="collapse" data-target="#Appviewsmob" href="Transport.aspx">Transport <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="Appviewsmob" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Transport</a>
                                                    </li>
                                                    <li><a href="#">Delete Transport</a>
                                                    </li>
                                                    <li><a href="#">Total Transport</a>
                                                    </li>
                                                </ul>
                                             
                                        </li>

                                            <li><a data-toggle="collapse" data-target="#Pagemob" href="Fee.aspx">Fee <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="Pagemob" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Fee</a>
                                                    </li>
                                                    <li><a href="#">View Fee</a>
                                                    </li>
                                                    <li><a href="#">Pending Fee</a>
                                                    </li>
                                                    <li><a href="#">Late Fee</a>
                                                    </li>
                                                </ul>
                                            </li>

                                            
                                            <li><a data-toggle="collapse" data-target="#Pagemob" href="Employee.aspx">Employee <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="Employee" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Employee</a>
                                                    </li>
                                                    <li><a href="#">View Employee</a>
                                                    </li>
                                                    <li><a href="#">Delete Employee</a>
                                                    </li>
                                                </ul>


                                                </li>

                                            <li><a data-toggle="collapse" data-target="#Pagemob" href="Payroll.aspx">Pay Roll <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>


                                                 <ul id="PayRoll" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Employee</a>
                                                    </li>
                                                    <li><a href="#">View Employee</a>
                                                    </li>
                                                    <li><a href="#">Delete Employee</a>
                                                    </li>
                                                </ul>

                                                </li>

                                            <li><a data-toggle="collapse" data-target="#Pagemob" href="Library.aspx">Library <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>


                                                 <ul id="Library" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Book</a>
                                                    </li>
                                                    <li><a href="#">View Details</a>
                                                    </li>
                                                    <li><a href="#">Book Issued</a>
                                                    </li>
                                                </ul>
                                                </li>

                                               <li><a data-toggle="collapse" data-target="#Pagemob" href="Teacher-Log.aspx">Teacher Log <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                    <ul id="TeacherLog" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Employee</a>
                                                    </li>
                                                    <li><a href="#">View Employee</a>
                                                    </li>
                                                    <li><a href="#">Delete Employee</a>
                                                    </li>
                                                </ul>
                                                </li>

                                            <li><a data-toggle="collapse" data-target="#Pagemob" href="AdminLog.aspx">Admin <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>

                                                 <ul id="Admin" class="collapse dropdown-header-top">
                                                    <li><a href="#">Add Employee</a>
                                                    </li>
                                                    <li><a href="#">View Employee</a>
                                                    </li>
                                                    <li><a href="#">Delete Employee</a>
                                                        <li><a href="#">Add Student</a>
                                                    </li>
                                                    <li><a href="#">View Student</a>
                                                    </li>
                                                    <li><a href="#">Delete Student</a>
                                                    </li>
                                                </ul>
                                                </li>

                                             <li><a data-toggle="collapse" data-target="#Pagemob" href="Health.aspx">Health<span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                 <ul id="Health" class="collapse dropdown-header-top">
                                                 <li><a href="#">View Details</a>
                                                    </li>
                                                     </ul>
                                                    

                                            <li><a data-toggle="collapse" data-target="#Pagemob" href="Pro.aspx">PRO <span class="admin-project-icon adminpro-icon adminpro-down-arrow"></span></a>
                                                <ul id="Pro" class="collapse dropdown-header-top">
                                                <li><a href="#">Add Employee</a>
                                                    </li>
                                                    <li><a href="#">View Employee</a>
                                                    </li>
                                                    <li><a href="#">Delete Employee</a>
                                                </li>
                                                    </ul>
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Mobile Menu end -->
                <div class="breadcome-area">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <div class="breadcome-list">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="section-admin container-fluid">
                    <div class="row admin text-center" style="margin-top:45px">
                        <div class="col-md-12">
                            <div class="row">
                                <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                    <div class="admin-content analysis-progrebar-ctn res-mg-t-15">
                                        <h4 class="text-left text-uppercase"><b>Student-Roll </b></h4>
                                        <div class="row vertical-center-box vertical-center-box-tablet">
                                            <div class="col-xs-3 mar-bot-15 text-left">
                                                <img src="img/iconsfordashboard/student-roll-new.png" />

                                            </div>
                                            <div class="col-xs-9 cus-gh-hd-pro">
                                                <h2 class="text-right no-margin">
                                                    <asp:Label ID="lblstudentroll" runat="server" Text="" style="font-size:10pt"></asp:Label></h2>

                                            </div>
                                        </div>
                                        <div class="progress progress-mini">
                                            <div style="width: 78%;" class="progress-bar bg-green"></div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12" style="margin-bottom: 1px;">
                                    <div class="admin-content analysis-progrebar-ctn res-mg-t-30">
                                        <h4 class="text-left text-uppercase"><b>Student-Attendence</b></h4>
                                        <div class="row vertical-center-box vertical-center-box-tablet">
                                            <div class="text-left col-xs-3 mar-bot-15">
                                                <img src="img/iconsfordashboard/student-attendance.png" />
                                            </div>
                                            <div class="col-xs-9 cus-gh-hd-pro">
                                                <h2 class="text-right no-margin">
                                                    <asp:Label ID="stndlbl" runat="server" Text="Label" style="font-size:10pt"></asp:Label></h2>
                                            </div>
                                        </div>
                                        <div class="progress progress-mini">
                                            <div style="width: 38%;" class="progress-bar progress-bar-danger bg-red"></div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                    <div class="admin-content analysis-progrebar-ctn res-mg-t-30">
                                        <h4 class="text-left text-uppercase"><b>Staff-Roll</b></h4>
                                        <div class="row vertical-center-box vertical-center-box-tablet">
                                            <div class="text-left col-xs-3 mar-bot-15">
                                                <img src="img/iconsfordashboard/staff-roll.png" />
                                            </div>
                                            <div class="col-xs-9 cus-gh-hd-pro">
                                                <h2 class="text-right no-margin">
                                                    <asp:Label ID="lblstaffroll" runat="server" Text="Label" style="font-size:10pt"></asp:Label></h2>

                                            </div>
                                        </div>
                                        <div class="progress progress-mini">
                                            <div style="width: 60%;" class="progress-bar bg-blue"></div>
                                        </div>
                                    </div>
                                </div>  
                                <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                    <div class="admin-content analysis-progrebar-ctn res-mg-t-30">
                                        <h4 class="text-left text-uppercase"><b>Staff-Attendence</b></h4>
                                        <div class="row vertical-center-box vertical-center-box-tablet">
                                            <div class="text-left col-xs-3 mar-bot-15">
                                                <img src="img/iconsfordashboard/staff-attendance.png" />
                                            </div>
                                            <div class="col-xs-9 cus-gh-hd-pro">
                                                <h2 class="text-right no-margin">
                                                    <asp:Label ID="lblstaffatt" runat="server" Text="Label" style="font-size:10pt"></asp:Label></h2>
                                            </div>
                                        </div>
                                        <div class="progress progress-mini">
                                            <div style="width: 60%;" class="progress-bar bg-purple"></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>





                <%--<div class="product-new-list-area">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                        <div class="single-new-trend mg-t-30">
                            <a href="#"><img src="img/new-product/5.jpg" alt=""></a>
                            <div class="overlay-content">
                                <a href="#">
                                    <h2>$280</h2>
                                </a>
                                <a href="#" class="btn-small">Now</a>
                                <div class="product-action">
                                    <ul>
                                        <li>
                                            <a data-toggle="tooltip" title="Shopping" href="#"><i class="fa fa-shopping-bag" aria-hidden="true"></i></a>
                                        </li>
                                        <li>
                                            <a data-toggle="tooltip" title="Quick view" href="#"><i class="fa fa-heart" aria-hidden="true"></i></a>
                                        </li>
                                    </ul>
                                </div>
                                <a href="#">
                                    <h4>Princes Diamond</h4>
                                </a>
                                <div class="pro-rating">
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                        <div class="single-new-trend mg-t-30">
                            <a href="#"><img src="img/new-product/6.jpg" alt=""></a>
                            <div class="overlay-content">
                                <a href="#">
                                    <h2>$280</h2>
                                </a>
                                <a href="#" class="btn-small">Now</a>
                                <div class="product-action">
                                    <ul>
                                        <li>
                                            <a data-toggle="tooltip" title="Shopping" href="#"><i class="fa fa-shopping-bag" aria-hidden="true"></i></a>
                                        </li>
                                        <li>
                                            <a data-toggle="tooltip" title="Quick view" href="#"><i class="fa fa-heart" aria-hidden="true"></i></a>
                                        </li>
                                    </ul>
                                </div>
                                <a href="#">
                                    <h4>Princes Diamond</h4>
                                </a>
                                <div class="pro-rating">
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                        <div class="single-new-trend mg-t-30">
                            <a href="#"><img src="img/new-product/7.jpg" alt=""></a>
                            <div class="overlay-content">
                                <a href="#">
                                    <h2>$280</h2>
                                </a>
                                <a href="#" class="btn-small">Now</a>
                                <div class="product-action">
                                    <ul>
                                        <li>
                                            <a data-toggle="tooltip" title="Shopping" href="#"><i class="fa fa-shopping-bag" aria-hidden="true"></i></a>
                                        </li>
                                        <li>
                                            <a data-toggle="tooltip" title="Quick view" href="#"><i class="fa fa-heart" aria-hidden="true"></i></a>
                                        </li>
                                    </ul>
                                </div>
                                <a href="#">
                                    <h4>Princes Diamond</h4>
                                </a>
                                <div class="pro-rating">
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                        <div class="single-new-trend mg-t-30">
                            <a href="#"><img src="img/new-product/5.jpg" alt=""></a>
                            <div class="overlay-content">
                                <a href="#">
                                    <h2>$280</h2>
                                </a>
                                <a href="#" class="btn-small">Now</a>
                                <div class="product-action">
                                    <ul>
                                        <li>
                                            <a data-toggle="tooltip" title="Shopping" href="#"><i class="fa fa-shopping-bag" aria-hidden="true"></i></a>
                                        </li>
                                        <li>
                                            <a data-toggle="tooltip" title="Quick view" href="#"><i class="fa fa-heart" aria-hidden="true"></i></a>
                                        </li>
                                    </ul>
                                </div>
                                <a href="#">
                                    <h4>Princes Diamond</h4>
                                </a>
                                <div class="pro-rating">
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star color"></i>
                                    <i class="fa fa-star"></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>--%>
                <div class="product-sales-area mg-tb-30">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-9 col-md-9 col-sm-9 col-xs-12">
                                <div class="product-sales-chart">
                                    <div class="portlet-title">
                                        <div class="row">
                                            <div class="col-lg-12 col-md-9 col-sm-9 col-xs-12">
                                                <div class="caption pro-sl-hd">
                                                    <span class="caption-subject text-uppercase"><b>Class Wise Roll</b></span>



                                                    <div class="overflowX">
                                                        <asp:MultiView ID="MultiView1" ActiveViewIndex="0" runat="server"> 
                                                            <asp:view ID="view1"  runat="server">
                                          <asp:GridView ID="grdView" AutoGenerateColumns="false" BorderWidth="0" runat="server"  OnRowCommand="grdView_RowCommand"    PageSize="15" OnPageIndexChanging="grdView_PageIndexChanging" CssClass="table" AllowPaging="true"  >
                                                            <PagerStyle HorizontalAlign="Center" CssClass="pagination-ys" />
                                                              
                                                            <RowStyle Height="2px" />
                                                            <AlternatingRowStyle Height="10px" />
                                                          


                                                            <Columns>

                                                                <asp:BoundField HeaderText="ID" DataField="ID" />
                                                                <asp:BoundField HeaderText="Name" DataField="Name" />
                                                                <asp:BoundField HeaderText="Address" DataField="Address" />
                                                                <asp:BoundField HeaderText="Phone" DataField="Phone" />
                                                                <asp:TemplateField HeaderText="Edit">

                                                                    <ItemTemplate>
                                                                        <asp:Button ID="BtnEdit" runat="server" CommandArgument='<%#Eval("ID")%>' CommandName="EditItem" CssClass="btn btn-info" Text="edit" />
                                                                    </ItemTemplate>
                                                                    </asp:TemplateField>


                                                                    <asp:TemplateField HeaderText="Delte">
                                                                        <ItemTemplate>
                                                                        <asp:Button ID="BtnDel" runat="server" CommandArgument='<%#Eval("ID")%>' CommandName="Delteitem" CssClass="btn btn-danger" Text="Delete" />
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>
 
                                                        </asp:GridView>
                                                            </asp:view>
                                                            <asp:view ID="view2"  runat="server">
                                                               
                                                                <asp:TextBox ID="TextBox1" runat="server">Address</asp:TextBox>
                                                                <asp:TextBox ID="TextBox2" runat="server">Name</asp:TextBox>
                                                                 <asp:TextBox ID="TextBox3" runat="server">Phone</asp:TextBox>
                                                                <asp:LinkButton ID="LinkButton1" runat="server">Update</asp:LinkButton>?
                                                                    
                                                            </asp:view> 

                                                        </asp:MultiView>
                   
                                                        
                                                    </div>

                                                </div>
                                            </div>
                                            <%--                                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                            <div class="actions graph-rp">
                                                <a href="#" class="btn btn-dark-blue btn-circle active tip-top" data-toggle="tooltip" title="Upload">
                                                    <i class="fa fa-cloud-download" aria-hidden="true"></i>
                                                </a>
                                                <a href="#" class="btn btn-dark btn-circle active tip-top" data-toggle="tooltip" title="Refresh">
                                                    <i class="fa fa-reply" aria-hidden="true"></i>
                                                </a>
                                                <a href="#" class="btn btn-blue-grey btn-circle active tip-top" data-toggle="tooltip" title="Delete">
                                                    <i class="fa fa-trash-o" aria-hidden="true"></i>
                                                </a>
                                            </div>
                                        </div>--%>
                                        </div>
                                    </div>
                                    <%--<ul class="list-inline cus-product-sl-rp">
                                    <li>
                                        <h5><i class="fa fa-circle" style="color: #24caa1;"></i>Bags</h5>
                                    </li>
                                    <li>
                                        <h5><i class="fa fa-circle" style="color: #888;"></i>Shoes</h5>
                                    </li>
                                    <li>
                                        <h5><i class="fa fa-circle" style="color: #ff7f5a;"></i>Jewelery</h5>
                                    </li>
                                </ul>--%>
                                    <div id="extra-area-chart"></div>
                                </div>
                            </div>



                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                <div class="analytics-rounded mg-b-10 res-mg-t-30">
                                    <div class="analytics-rounded-content">
                                        <h5>Percentage distribution</h5>
                                        <h2><span class="counter">60</span>/20</h2>
                                        <div class="text-center">
                                            <div id="sparkline51"></div>
                                        </div>
                                    </div>
                                </div>
                                <div class="analytics-rounded">
                                    <div class="analytics-rounded-content">
                                        <h5>Percentage division</h5>
                                        <h2><span class="counter">150</span>/<span class="counter">54</span></h2>
                                        <div class="text-center">
                                            <div id="sparkline52"></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="traffic-analysis-area">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
                                <div class="white-box tranffic-als-inner">
                                    <h3 class="box-title"><small class="pull-right m-t-10 text-success"><i class="fa fa-sort-asc"></i>18% last month</small> INSURANCE</h3>
                                    <div class="stats-row">
                                        <div class="stat-item">
                                            <h6>Overall Growth</h6>
                                            <b>80.40%</b>
                                        </div>
                                        <div class="stat-item">
                                            <h6>Montly</h6>
                                            <b>15.40%</b>
                                        </div>
                                        <div class="stat-item">
                                            <h6>Day</h6>
                                            <b>5.50%</b>
                                        </div>
                                    </div>
                                    <div id="sparkline8"></div>
                                </div>
                            </div>
                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
                                <div class="white-box tranffic-als-inner res-mg-t-30">
                                    <h3 class="box-title"><small class="pull-right m-t-10 text-danger"><i class="fa fa-sort-desc"></i>18% last month</small>TOKEN</h3>
                                    <div class="stats-row">
                                        <div class="stat-item">
                                            <h6>Overall Growth</h6>
                                            <b>80.40%</b>
                                        </div>
                                        <div class="stat-item">
                                            <h6>Montly</h6>
                                            <b>15.40%</b>
                                        </div>
                                        <div class="stat-item">
                                            <h6>Day</h6>
                                            <b>5.50%</b>
                                        </div>
                                    </div>
                                    <div id="sparkline9"></div>
                                </div>
                            </div>
                            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">
                                <div class="white-box tranffic-als-inner res-mg-t-30">
                                    <h3 class="box-title"><small class="pull-right m-t-10 text-success"><i class="fa fa-sort-asc"></i>18% last month</small>POLLUTION</h3>
                                    <div class="stats-row">
                                        <div class="stat-item">
                                            <h6>Overall Growth</h6>
                                            <b>80.40%</b>
                                        </div>
                                        <div class="stat-item">
                                            <h6>Montly</h6>
                                            <b>15.40%</b>
                                        </div>
                                        <div class="stat-item">
                                            <h6>Day</h6>
                                            <b>5.50%</b>
                                        </div>
                                    </div>
                                    <div id="sparkline10"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



                <div class="calender-area mg-tb-30">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-12">
                                <div class="calender-inner">
                                    <div id='calendar'></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="footer-copyright-area">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-12">
                                <div class="footer-copy-right">
                                    <p>Copyright &copy; 2019 <a href="#">National</a>ITSolutions.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>

