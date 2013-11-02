<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="VistaWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-sm-8">
            Publicaciones
        </div>
        <div class="col-sm-3 col-sm-offset-1">
            <div class="row">Lista de Amigos</div>
            <div class="row">
                <asp:ListBox ID="AmigosList" runat="server"></asp:ListBox>
            </div>
        </div>
    </div>
</asp:Content>
