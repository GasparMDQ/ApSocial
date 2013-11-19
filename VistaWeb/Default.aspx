<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="VistaWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-sm-8">
                <ul class="nav nav-tabs">
                  <li class="active"><a href="#new-estado" data-toggle="tab">Estado</a></li>
                  <li><a href="#new-album" data-toggle="tab">Album de Fotos</a></li>
                </ul>
                <div class="tab-content">
                  <div class="tab-pane fade in active" id="new-estado">
                    <asp:TextBox ID="estadoMsg" runat="server" CssClass="form-control" placeholder="En que estas pensando ..."></asp:TextBox>
                    <asp:FileUpload ID="estadoFoto" runat="server" />
                    <asp:Button ID="nuevoEstado" runat="server" Text="Enviar" 
                          CssClass="btn btn-primary btn-sm" onclick="nuevoEstado_Click" />
                  </div>
                  <div class="tab-pane fade" id="new-album">
                    <input class="form-control" placeholder="Escribe el titulo para tu nuevo album ..."/>
                  </div>
                </div>
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
