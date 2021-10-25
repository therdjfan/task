<%@ Page Language="C#" AutoEventWireup="true" CodeFile="crudop.aspx.cs" Inherits="Task11.crudop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <table>  
        <tr>  
            <td class="td">Product Id:</td>  
            <td><asp:TextBox ID="proid" runat="server"></asp:TextBox></td>  
            <td>
                <asp:Button ID="Getdata" runat="server" Text="Get" OnClick="Getdata_Click" /> </td>  
        </tr>  
        <tr>  
            <td class="td">Product Name:</td>  
            <td><asp:TextBox ID="proname" runat="server" T></asp:TextBox></td>  
            <td> </td>  
        </tr>  
       
        
        <tr>
           <td>Category Id:</td>
           <td> <asp:TextBox ID="catid" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
           <td>Categoy Name:</td>
           <td><asp:TextBox ID="catname" runat="server"></asp:TextBox></td>
        </tr>
       
        <tr>  
           
            <td>  
                <asp:Button ID="btnnsert" runat="server" Text="Submit" OnClick="btnnsert_Click"   />  
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"  />  
  
                <asp:Button ID="btnCancel" runat="server" Text="Delete" OnClick="btnCancel_Click"  />
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
           </td>  
        </tr>  
    </table>  
   <div style="padding: 10px; margin: 0px; " class="auto-style2">  
       
     
     <div> <asp:GridView ID="GridView1" runat="server"  style="height:auto;width:100%;"></asp:GridView>
     </div> 
    </div> 
        </div>
    </form>
</body>
</html>
