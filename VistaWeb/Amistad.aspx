<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Amistad.aspx.cs" Inherits="VistaWeb.Amistad" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="row well">
            <h3>Solicitudes pendientes <span class="badge">
                <asp:Label ID="solicitudesPendientesLbl" runat="server" Text="0"></asp:Label></span></h3>
        <div class="row">
            <div class="col-md-2">
                <select id="ListaSolicitudes" name="D1">
                    <asp:Literal ID="OpcionesSolicitud" runat="server"></asp:Literal>
                </select></div>
            <div class="col-md-9 col-md-offset-1" id="detalleUsuario">
            </div>
        </div>
    </div>
    <div class="row well">
        <p>
            <button class="btn btn-info" data-toggle="modal" data-target="#newFriend">Agregar amigo</button>
        </p>
        <span class="alert-danger">
            <asp:Literal ID="resultadoSolicitud" runat="server"></asp:Literal>
        </span>
    </div>

    <div class="modal fade" id="newFriend" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
            <h4 class="modal-title" id="myModalLabel">Nueva Solicitud de Amistad</h4>
          </div>
          <div class="modal-body">
            <div class="row">
                <div class="col-md-10 col-md-offset-1">
                    <div class="form-group">
                        <asp:Label ID="emailSolicitudLabel" runat="server" Text="Email" AssociatedControlID="emailSolicitud"></asp:Label>
                        <asp:TextBox ID="emailSolicitud" type="email" class="form-control" placeholder="Ingrese el email" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
            <asp:Button ID="enviarSolicitud" class="btn btn-primary" runat="server" 
                  Text="Enviar Solicitud" onclick="enviarSolicitud_Click" />
          </div>
        </div><!-- /.modal-content -->
      </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->

</asp:Content>
