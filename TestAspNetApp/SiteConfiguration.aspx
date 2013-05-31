<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SiteConfiguration.aspx.cs" Inherits="TestAspNetApp.SiteConfiguration" %>
<%@ Import Namespace="System.Reflection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Assembly: <asp:Label runat="server" id="AssemblyNameLabel"></asp:Label>
    </p>

    <p>                
        Version:        
        <asp:Label runat="server" id="VersionLabel"></asp:Label>
    </p>
</asp:Content>
