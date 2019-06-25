<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageMain.master" AutoEventWireup="true" CodeFile="AddStudent1.aspx.cs" Inherits="Student_AddStudent1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentSide" Runat="Server">
     <%-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
<link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>
    
    <title>Easio Dashboard</title>
    <link href="../css/TestStyle.css" rel="stylesheet" />esheet" />
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- favicon
		============================================ -->
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.ico">
    <!-- Google Fonts
		============================================ -->
    <link href="../css/GoogleFonts.css" rel="stylesheet" />
    
    <!-- Bootstrap CSS
		=========================
        
        =================== -->
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <!-- Bootstrap CSS
		============================================ -->
    <link rel="stylesheet" href="../css/font-awesome.min.css">
    <!-- owl.carousel CSS
		============================================ -->
    <link rel="stylesheet" href="../css/owl.carousel.css">
    <link rel="stylesheet" href="../css/owl.theme.css">
    <link rel="stylesheet" href="../css/owl.transitions.css">
    <!-- animate CSS
		============================================ -->
    <link rel="stylesheet" href="../css/animate.css">
    <!-- normalize CSS
		============================================ -->
    <link rel="stylesheet" href="../css/normalize.css">
    <!-- meanmenu icon CSS
		============================================ -->
    <link rel="stylesheet" href="../css/meanmenu.min.css">
    <!-- main CSS
		============================================ -->
    <link rel="stylesheet" href="../css/main.css">
    <!-- morrisjs CSS
		============================================ -->
    <link rel="stylesheet" href="../css/morrisjs/morris.css">
    <!-- mCustomScrollbar CSS
		============================================ -->
    <link rel="stylesheet" href="../css/scrollbar/jquery.mCustomScrollbar.min.css">
    <!-- metisMenu CSS
		============================================ -->
    <link rel="stylesheet" href="../css/metisMenu/metisMenu.min.css">
    <link rel="stylesheet" href="../css/metisMenu/metisMenu-vertical.css">
    <!-- calendar CSS
		============================================ -->
    <link rel="stylesheet" href="../css/calendar/fullcalendar.min.css">
    <link rel="stylesheet" href="../css/calendar/fullcalendar.print.min.css">
    <!-- style CSS
		============================================ -->
    <link rel="stylesheet" href="../css/style.css">
    <!-- responsive CSS
		============================================ -->
    <link rel="stylesheet" href="../css/responsive.css">
    <!-- modernizr JS
		============================================ -->
    <script src="../js/vendor/modernizr-2.8.3.min.js"></script>


    <!-- jquery
		============================================ -->
    <script src="../js/vendor/jquery-1.11.3.min.js"></script>
    <!-- bootstrap JS
		============================================ -->
    <script src="../js/bootstrap.min.js"></script>
    <!-- wow JS
		============================================ -->
    <script src="../js/wow.min.js"></script>
    <!-- price-slider JS
		============================================ -->
    <script src="../js/jquery-price-slider.js"></script>
    <!-- meanmenu JS
		============================================ -->
    <script src="../js/jquery.meanmenu.js"></script>
    <!-- owl.carousel JS
		============================================ -->
    <script src="../js/owl.carousel.min.js"></script>
    <!-- sticky JS
		============================================ -->
    <script src="../js/jquery.sticky.js"></script>
    <!-- scrollUp JS
		============================================ -->
    <script src="../js/jquery.scrollUp.min.js"></script>
    <!-- mCustomScrollbar JS
		============================================ -->
    <script src="../js/scrollbar/jquery.mCustomScrollbar.concat.min.js"></script>
    <script src="../js/scrollbar/mCustomScrollbar-active.js"></script>
    <!-- metisMenu JS
		============================================ -->
    <script src="../js/metisMenu/metisMenu.min.js"></script>
    <script src="../js/metisMenu/metisMenu-active.js"></script>
    <!-- morrisjs JS
		============================================ -->
    <script src="../js/morrisjs/raphael-min.js"></script>
    <script src="../js/morrisjs/morris.js"></script>
    <script src="../js/morrisjs/morris-active.js"></script>
    <!-- morrisjs JS


		============================================ -->
    <script src="../js/sparkline/jquery.sparkline.min.js"></script>
    <script src="../js/sparkline/jquery.charts-sparkline.js"></script>
    <!-- calendar JS
		============================================ -->
    <script src="../js/calendar/moment.min.js"></script>
    <script src="../js/calendar/fullcalendar.min.js"></script>
    <script src="../js/calendar/fullcalendar-active.js"></script>
    <!-- plugins JS
		============================================ -->
    <script src="../js/plugins.js"></script>
    <!-- main JS
		============================================ -->
    <script src="../js/main.js"></script>

    
    
    <div class="left-custom-menu-adp-wrap comment-scrollbar">

         <div>
                           <a href="../Default.aspx">  <img  src="../img/easio-logo2.png" height="110px" width="130px" style="margin-left:25px" /> </a>
                        </div>

                    <nav class="sidebar-nav left-sidebar-menu-pro">
                        <ul class="metismenu" id="menu1">


                            <li class="b-inner">
                                <a href="../StudentDashboard.aspx"><i class="fa fa-graduation-cap"></i>&nbsp;&nbsp; Students</a>                              
                            </li>
                                
                            
                <li class="a-inner" style="display: table-row"><a href="Student/addstudents.aspx" class="a-inner-middle" style="display: table-cell; vertical-align: middle;"><i class="fa fa-caret-square-o-right" style="font-size: 14px"></i><span class="inner-span"> Add Student </span></a></li>
                        
                           
                            </ul>                              
                        
                    </nav>
                </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentbody" Runat="Server">
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
                            <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12" style="padding-right: 11px !important;">
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
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentDisplay" Runat="Server">
    <style>
  
    legend {
        /* display: block; */
        width: auto;
        padding: 0;
        margin-bottom: 20px;
        font-size: 15px;
        line-height: inherit;
        color: #000000;
        border: 0;
        /* border-bottom: 1px solid #e5e5e5; */
        margin-left: 33px;
        font-weight: bold;
    }

    fieldset {
        border: 1px solid #cbcbcb;
        width: 90%;
        margin-top: 10px;
        margin-left: 20px;
       
    }
        </style>

     <div class="col-md-12 center-block text-center" style="margin-top: 20px;">
        <h3><span style="color: #9d0e0a">Add</span> Student </h3>
        <hr class="center-block text-center" style="border: 1px solid #808080; text-align: center; background-color: #000000; margin-top: -6px; width: 25%" />
    </div>
    <div style="padding: 15px;">
        <asp:label id="lblSuccess" visible="false" runat="server" cssclass="col-md-12 center-block text-center alert-success" />
        <asp:label id="lblError" visible="false" runat="server" cssclass="col-md-12 center-block text-center alert-danger" />
    </div>
     <asp:Multiview id="multiview1" activeviewindex="0" runat="server">
    <asp:View ID="view1" runat="server">
            <div class="container-fluid">
                <div class="col-md-12">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
    
              
        <fieldset style="height:500px">
             
            <legend>Add Student</legend>
            <div class="col-md-12">
                <div class="col-md-4 form-group">
                    ID No:
                  
          <asp:TextBox runat="server" ID="txtidno" CssClass="form-control" ValidationGroup="add" Height="35px" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtidno" runat="server"  />
                   
                </div>
                 <div class="col-md-4 form-group">
                    Name:
                  
          <asp:TextBox runat="server" ID="txtname" CssClass="form-control" ValidationGroup="add"  Height="35px" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtname" runat="server" />
                    
                </div>

                 <div class="col-md-4 form-group">
                    Admit To Class<span style="color: red;"></span>:
        <asp:DropDownList ID="DropDownList1" CssClass="form-control  " ValidationGroup="add"
            runat="server"  Height="35px">
            <asp:ListItem Value="0" Selected="True">Class?</asp:ListItem>
            <asp:ListItem Value="1">Nursery </asp:ListItem>
            <asp:ListItem Value="2">LKG</asp:ListItem>
             <asp:ListItem Value="1">UKG </asp:ListItem>
            <asp:ListItem Value="2">First</asp:ListItem>
        </asp:DropDownList>

                  
                </div>
            </div>

             <div class="col-md-12">

                 <div class="col-md-4 form-group">
                    Select Section<span style="color: red;"></span>:
        <asp:DropDownList ID="DropDownList2" CssClass="form-control  " ValidationGroup="add"
            runat="server"  Height="35px">
            <asp:ListItem Value="0" Selected="True">Section?</asp:ListItem>
            <asp:ListItem Value="1">A </asp:ListItem>
            <asp:ListItem Value="2">B</asp:ListItem>
             <asp:ListItem Value="1">C </asp:ListItem>
            <asp:ListItem Value="2">D</asp:ListItem>
        </asp:DropDownList>

                  
                </div>

                  <div class="col-md-4 form-group">
                    Addmission No:
                  
          <asp:TextBox runat="server" ID="txtadmission" CssClass="form-control" ValidationGroup="add"  Height="35px" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtadmission" runat="server" />
                    
                </div>
                 <div class="col-md-4 form-group">
                    Roll No:
                  
          <asp:TextBox runat="server" ID="txtrollno" CssClass="form-control" ValidationGroup="add"  Height="35px" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtrollno" runat="server" />
                    
                </div>
                 
            </div>
            
             <div class="col-md-12">
                 <div class="col-md-4 form-group">
                    Board Registration No:
                  
          <asp:TextBox runat="server" ID="txtboardregistno" CssClass="form-control" ValidationGroup="add"  Height="35px" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtboardregistno" runat="server" />
                   
                </div>
                  <div class="col-md-4 form-group">
                    Stream<span style="color: red;"></span>:
        <asp:DropDownList ID="ddlstream" CssClass="form-control  " ValidationGroup="add"
            runat="server"  Height="35px">
            <asp:ListItem Value="0" Selected="True">General?</asp:ListItem>
            <asp:ListItem Value="1">A </asp:ListItem>
            <asp:ListItem Value="2">B</asp:ListItem>
             <asp:ListItem Value="1">C </asp:ListItem>
            <asp:ListItem Value="2">D</asp:ListItem>
        </asp:DropDownList>
                 </div>
                 <div class="col-md-4 form-group">
                    Optional If Applicable<span style="color: red;"></span>:
        <asp:DropDownList ID="ddloptionalifapplicable" CssClass="form-control  " ValidationGroup="add"
            runat="server"  Height="35px">
            <asp:ListItem Value="0" Selected="True">Select?</asp:ListItem>
            <asp:ListItem Value="1">Yes </asp:ListItem>
            <asp:ListItem Value="2">NO</asp:ListItem>
             
        </asp:DropDownList>
                 </div>
                 </div>
              <div class="col-md-12">
                  <div class="col-md-4 form-group">
                    Optional<span style="color: red;"></span>:
        <asp:DropDownList ID="ddlgeneral" CssClass="form-control  " ValidationGroup="add"
            runat="server"  Height="35px">
            <asp:ListItem Value="0" Selected="True">Select?</asp:ListItem>
            <asp:ListItem Value="1">A </asp:ListItem>
            <asp:ListItem Value="2">B</asp:ListItem>
            
        </asp:DropDownList>
                 </div>
                  <div class="col-md-4 form-group">
                    Date Of Birth:
                  
          <asp:TextBox runat="server" ID="txtdob" CssClass="form-control" ValidationGroup="add" TextMode="Date"  Height="35px" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtdob" runat="server" />
                    
                </div>
                  <div class="col-md-4 form-group">
                    Date Of Addmission:
                  
          <asp:TextBox runat="server" ID="txtdoadmission" CssClass="form-control" ValidationGroup="add" TextMode="Date"  Height="35px"/>
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtdoadmission" runat="server" />
                    
                </div>
                  </div>
            <div class="col-md-12">
                  <div class="col-md-4 form-group">
                    Gender<span style="color: red;"></span>:
        <asp:DropDownList ID="ddlgenders" CssClass="form-control " ValidationGroup="add"
            runat="server"  Height="35px">
            <%--<asp:ListItem Value="0" Selected="True"></asp:ListItem>--%>
            <asp:ListItem Value="1">Male </asp:ListItem>
            <asp:ListItem Value="2">Female</asp:ListItem>
            
        </asp:DropDownList>
                 </div>
                  
                </div>
                  
         

        </fieldset>
             
             
             </div>





                        
                    </div>
                </div>




        <div class="container-fluid">
                <div class="col-md-12">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
    

          <fieldset style="height:200px">
            <legend>Parent Details</legend>
             <div class="col-md-12">
                <div class="col-md-4 form-group">
                    Father's Name:
                  
          <asp:TextBox runat="server" ID="txtfathername" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtfathername" runat="server" />
                   
                </div>
                
                <div class="col-md-4 form-group">
                    Father's Qualifaction:
                  
          <asp:TextBox runat="server" ID="txtfatherqualf" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtfatherqualf" runat="server" />
                   
                </div>
                     <div class="col-md-4 form-group">
                    Father's Occupation:
                  
          <asp:TextBox runat="server" ID="txtdfatheroccuption" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtdfatheroccuption" runat="server" />
                   
                </div>
                 </div>
            <div class="col-md-12">
                <div class="col-md-4 form-group">
                    Mother's Name:
                  
          <asp:TextBox runat="server" ID="txtmothername" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtmothername" runat="server" />
                   
                </div>
                
                <div class="col-md-4 form-group">
                    Mother's Qualifaction:
                  
          <asp:TextBox runat="server" ID="txtmotherqualf" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtmotherqualf" runat="server" />
                   
                </div>
                     <div class="col-md-4 form-group">
                    Mother's Occupation:
                  
          <asp:TextBox runat="server" ID="txtmotheroccuption" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtmotheroccuption" runat="server" />
                   
                </div>
                  
                 </div>
        </fieldset>


</div>
                    </div>
            </div>

         <div class="container-fluid">
                <div class="col-md-12">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
    

          <fieldset style="height:200px">
            <legend>Contact Details</legend>
             <div class="col-md-12">
                <div class="col-md-4 form-group">
                    Present Address:
                  
          <asp:TextBox runat="server" ID="txtpresentaddrs" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtpresentaddrs" runat="server" />
                   
                </div>
                 <div class="col-md-4 form-group">
                    Permenant Address:
                  
          <asp:TextBox runat="server" ID="txtpremntaddres" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtpremntaddres" runat="server" />
                   
                </div>
                 <div class="col-md-4 form-group">
                    Landline No :
                  
          <asp:TextBox runat="server" ID="txtlandlineno" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtlandlineno" runat="server" />
                   
                </div>

                 </div>
               <div class="col-md-12">
                   <div class="col-md-4 form-group">
                    Mobile No:
                  
          <asp:TextBox runat="server" ID="txtmobileno" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtmobileno" runat="server" />
                   
                </div>
                   <div class="col-md-4 form-group">
                    Father's Cell No:
                  
          <asp:TextBox runat="server" ID="txtfthrcellno" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtfthrcellno" runat="server" />
                   
                </div>
                   <div class="col-md-4 form-group">
                     Mother's Cell No:
                  
          <asp:TextBox runat="server" ID="txtmothercelno" CssClass="form-control" ValidationGroup="add" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtmothercelno" runat="server" />
                   
                </div>
                   
                   </div>

             </fieldset>
</div>
                    </div>
            </div>



         <div class="container-fluid">
                <div class="col-md-12">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
 <fieldset style="height:250px">
            <legend>Transport Detail</legend>
                  <div class="col-md-12">
               
            <div class="col-md-4 form-group">
                    Bus No:<span style="color: red;"></span>
        <asp:DropDownList ID="ddlbusno" CssClass="form-control  " ValidationGroup="add"
            runat="server">
            <asp:ListItem Value="0" Selected="True">Select?</asp:ListItem>
            <asp:ListItem Value="1">A </asp:ListItem>
            <asp:ListItem Value="2">B</asp:ListItem>
             <asp:ListItem Value="1">C </asp:ListItem>
            <asp:ListItem Value="2">D</asp:ListItem>
        </asp:DropDownList>


                   </div>
                       <div class="col-md-4 form-group">
                    Bus Stop:<span style="color: red;"></span>
        <asp:DropDownList ID="ddlbusstop" CssClass="form-control " ValidationGroup="add"
            runat="server">
            <asp:ListItem Value="0" Selected="True">Select?</asp:ListItem>
            <asp:ListItem Value="1">A </asp:ListItem>
            <asp:ListItem Value="2">B</asp:ListItem>
             <asp:ListItem Value="1">C </asp:ListItem>
            <asp:ListItem Value="2">D</asp:ListItem>
        </asp:DropDownList>


                   </div>
                       <div class="col-md-4 form-group">
                    Fee Catagory:<span style="color: red;"></span>
        <asp:DropDownList ID="ddlfeecatagory" CssClass="form-control " ValidationGroup="add"
            runat="server">
            <asp:ListItem Value="0" Selected="True">Select?</asp:ListItem>
            <asp:ListItem Value="1">A </asp:ListItem>
            <asp:ListItem Value="2">B</asp:ListItem>
             <asp:ListItem Value="1">C </asp:ListItem>
            <asp:ListItem Value="2">D</asp:ListItem>
        </asp:DropDownList>


                   </div>



                      </div>
            <div class="col-md-12">
             <div class="col-md-4 form-group">
                     Photo:
                  
         <asp:FileUpload ID="photoupload" CssClass="form-control" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtmothercelno" runat="server" />
                   
                </div>
                 <div class="col-md-4 form-group">
                     Remarks:
                  
          <asp:TextBox runat="server" ID="txtremark" CssClass="form-control" ValidationGroup="add" TextMode="MultiLine" Height="100px" />
                    <asp:RequiredFieldValidator ErrorMessage="*" ValidationGroup="add" SetFocusOnError="true"
                        ControlToValidate="txtremark" runat="server" />
                   
                </div>
                
            </div>

        </fieldset>

 <div class="col-md-12">
                    <div class="col-md-4 form-group"  style="margin-left:40%;margin-top:10px">
                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" CssClass="btn btn-info" />
              </div>

        </div>
                    </div>
            </div>
        
                        </asp:View>
         </asp:Multiview>
</asp:Content>

