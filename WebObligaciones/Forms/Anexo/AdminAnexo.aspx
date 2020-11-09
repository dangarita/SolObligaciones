<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminAnexo.aspx.cs" Inherits="WebObligaciones.Forms.Anexo.AdminAnexo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:GridView ID="grvAnexo" runat="server" AutoGenerateColumns="False" GridLines="None"
            AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"
            PageSize="7">
            <Columns>
                <asp:BoundField DataField="NomAnexo" HeaderText="Nombre" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
