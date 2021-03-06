<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Galatee.ModuleLoader</title>
    <style type="text/css">
    html, body {
	    height: 100%;
		width:100%;
	    overflow: auto;
    }
    body {
	    padding: 0;
	    margin: 0;
    }
    #silverlightControlHost {
	    height: 100%;
		width:100%;
	    text-align:center;
    }
    </style>
    <script type="text/javascript" src="Silverlight.js"></script>
    <script type="text/javascript">
        function onSilverlightError(sender, args) {
            var appSource = "";
            if (sender != null && sender != 0) {
              appSource = sender.getHost().Source;
            }
            
            var errorType = args.ErrorType;
            var iErrorCode = args.ErrorCode;

            if (errorType == "ImageError" || errorType == "MediaError") {
              return;
            }

            var errMsg = "Erreur non gérée de l'application Silverlight " +  appSource + "\n" ;

            errMsg += "Code : "+ iErrorCode + "    \n";
            errMsg += "Catégorie : " + errorType + "       \n";
            errMsg += "Message : " + args.ErrorMessage + "     \n";

            if (errorType == "ParserError") {
                errMsg += "Fichier : " + args.xamlFile + "     \n";
                errMsg += "Ligne : " + args.lineNumber + "     \n";
                errMsg += "Position : " + args.charPosition + "     \n";
            }
            else if (errorType == "RuntimeError") {           
                if (args.lineNumber != 0) {
                    errMsg += "Ligne : " + args.lineNumber + "     \n";
                    errMsg += "Position : " +  args.charPosition + "     \n";
                }
                errMsg += "Nom de la méthode " + args.methodName + "     \n";
            }

            throw new Error(errMsg);
        }
    </script>
</head>
<body>
      <div style=" background:#737373; height:55px; width:100%"> <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logogala.png" Width="200px" /> </div>    
    <form id="form1" runat="server" style="height:100%; width:100%;">
    <div id="silverlightControlHost">
        <object data="data:application/x-silverlight-2," type="application/x-silverlight-2" width="100%" height="100%">
		  <param name="source" value="ClientBin/Galatee.ModuleLoader.xap"/>
		  <param name="onError" value="onSilverlightError" />
		  <param name="background" value="white" />
		  <param name="minRuntimeVersion" value="4.0.50826.0" />
		  <param name="autoUpgrade" value="true" />
		  <a href="http://go.microsoft.com/fwlink/?LinkID=149156&v=4.0.50826.0" style="text-decoration:none">
 			  <img src="http://go.microsoft.com/fwlink/?LinkId=161376" alt="Télécharger Microsoft Silverlight" style="border-style:none"/>
		  </a>
	    </object><iframe id="_sl_historyFrame" style="visibility:hidden;height:0px;width:0px;border:0px"></iframe></div>
    </form>
</body>
</html>
