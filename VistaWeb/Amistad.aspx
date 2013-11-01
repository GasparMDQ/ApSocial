<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Amistad.aspx.cs" Inherits="VistaWeb.Amistad" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-8 col-md-offset-1">
            Listar solicitudes de amistad
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <button class="btn btn-info">Agregar amigo</button> (disparar ventana modal)
        </div>
    </div>
</asp:Content>
