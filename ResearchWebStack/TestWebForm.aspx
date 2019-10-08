<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWebForm.aspx.cs" Inherits="ResearchWebStack.TestWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtResult" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="btnTest" runat="server" Text="get Unit Result" OnClick="btnTest_Click" />
        </div>
    </form>
</body>
</html>
