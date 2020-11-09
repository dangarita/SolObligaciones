<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminCapitulo.aspx.cs" Inherits="WebObligaciones.Forms.Capitulo.AdminCapitulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:GridView ID="grvCapitulo" runat="server" AutoGenerateColumns="False" GridLines="None"
            AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"
            PageSize="7">
            <columns>
                    <asp:BoundField DataField="NomCapitulo" HeaderText="Nombre" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                </columns>
        </asp:GridView>
    </div>
</asp:Content>
