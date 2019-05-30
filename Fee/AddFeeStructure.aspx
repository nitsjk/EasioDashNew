<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFeeStructure.aspx.cs" Inherits="FeeAdvance_AddFeeStructure" %>

<%@ Register Src="~/Fee/FeeStructure.aspx" TagPrefix="uc1" TagName="FeeStructure" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title> 
<link href="../bootstrap-3.3.6/css/bootstrap.min.css" rel="stylesheet" /> 
 


      <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
   
    <script src="plugins/jQuery/jquery-2.2.3.min.js"></script> 
    <script src="plugins/jQueryUI/jquery-ui.min.js"></script> 
    <script>
        $.widget.bridge('uibutton', $.ui.button);
    </script> 
    <script src="bootstrap/js/bootstrap.min.js"></script>


     
    <script src="dist/js/app.min.js"></script>


    <script type="text/javascript" src="./highslide/highslide-with-html.js"></script>

    <script type="text/javascript">
        hs.graphicsDir = './highslide/graphics/';
        hs.outlineType = 'rounded-white';
        hs.wrapperClassName = 'draggable-header';
        hs.width = 800;
        hs.height = 700;

    </script>

    <!-- Bootstrap 3.3.6 -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css" />
    <link href="bootstrap/css/StyleSheet.css" rel="stylesheet" />

    <link href="bootstrap/StyleSheet.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link href="font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />

    <!-- Ionicons -->

    <!-- Theme style -->
    <link rel="stylesheet" href="dist/css/AdminLTE.min.css" />
    <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
    <link rel="stylesheet" href="dist/css/skins/_all-skins.min.css" />

    <link href="./highslide/highslide.css" rel="stylesheet" type="text/css" />




</head>
<body>
    <form id="form1" runat="server">
      
        <div class="container">
           

        <uc1:FeeStructure runat="server" ID="FeeStructure" />

        </div>
    </form>
</body>
</html>
