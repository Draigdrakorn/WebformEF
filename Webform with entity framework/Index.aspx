<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Webform_with_entity_framework.Index" %>

<%@ Register Src="~/CRUDOperation.ascx" TagPrefix="uc1" TagName="CRUDOperation" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:CRUDOperation runat="server" ID="CRUDOperation" />
    </form>
</body>
</html>
