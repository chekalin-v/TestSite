<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Products.aspx.cs" 
    Inherits="TestAspNetApp.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <ASP:Repeater id="MyRepeater" runat="server">
      <HeaderTemplate>
         <Table width="100%" style="font: 8pt verdana">
            <tr style="background-color:DFA894">
               <th>
                  Id
               </th>
               <th>
                  Name
               </th>
               <th>
                  Description
               </th> 
               <th>
                   Category
               </th>              
            </tr>
      </HeaderTemplate>

      <ItemTemplate>
            <tr style="background-color:FFECD8">
               <td>
                  <%# DataBinder.Eval(Container.DataItem, "Id") %>
               </td>
               <td>
                  <%# DataBinder.Eval(Container.DataItem,"Name") %>
               </td>
               <td>
                  <%# DataBinder.Eval(Container.DataItem, "Description") %>
               </td>              
               <td>
                  <%# DataBinder.Eval(Container.DataItem, "Category") %>
               </td>              
            </tr>
      </ItemTemplate>

      <FooterTemplate>
         </Table>
      </FooterTemplate>
   </ASP:Repeater>

</asp:Content>
