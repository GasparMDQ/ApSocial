﻿<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="VistaWeb._Default" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="ApSocial.Entidades" %>
<%@ Register Src="~/FriendList.ascx" TagName="FriendList" TagPrefix="apsocial" %> 

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
                      <asp:Panel ID="ContenedorFormulario" CssClass="form-group" runat="server">
                       <br />
                        <p>
                            <asp:TextBox ID="estadoMsg" runat="server" CssClass="form-control" placeholder="En que estas pensando ..."></asp:TextBox> <br />
                            <asp:Button ID="nuevoEstado" runat="server" Text="Enviar" CssClass="btn btn-primary btn-sm pull-right" onclick="nuevoEstado_Click" />
                        </p>
                        <p>
                            <asp:FileUpload ID="estadoFoto" runat="server" />
                        </p>
                      </asp:Panel>
                  </div>
                  <div class="tab-pane fade" id="new-album">
                    <br />
                        <input class="form-control" placeholder="Escribe el titulo para tu nuevo album ..."/>
                    <br />
                  </div>
                </div>
            <asp:Repeater ID="Publicaciones" runat="server">
                <ItemTemplate>
	                <div class="row">
		                <div class="well well-sm ">
				            <div class="btn-group pull-right">
                                <a href="#" title="<%# DataBinder.Eval(Container.DataItem,"Usuario") %>"><img class="img-responsive img-thumbnail app-wall-thumb" src="<%# DataBinder.Eval(Container.DataItem,"foto_estado") %>" alt="Imagen" /></a>
				            </div>
			                <blockquote>
				                <p><%# DataBinder.Eval(Container.DataItem,"Mensaje") %></p>
                                <small><%# DataBinder.Eval(Container.DataItem,"Usuario") %></small>
			                </blockquote>
                            <!-- Lista de Comentarios -->
                            <asp:Repeater ID="Comentarios" runat="server" DataSource='<%# Eval("Comentarios") %>' onitemcommand="Publicaciones_ItemCommand">
                                <ItemTemplate>
                                    <div class="well well-sm ">
                                        <small><%# Eval("Usuario") %></small>: <%# Eval("Mensaje") %>
                                    </div>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="newComentario" CssClass="form-control" runat="server" placeholder="Escribe un comentario ..."></asp:TextBox>
                                    <asp:Button ID="newComentarioBtn" CssClass="btn btn-default btn-sm" runat="server" Text="Enviar" UseSubmitBehavior="False" CommandName="newComment" CommandArgument='<%# DataBinder.Eval(((RepeaterItem)Container.Parent.Parent).DataItem,"Id") %>' />
                                </FooterTemplate>
                            </asp:Repeater>
                            <!-- Fin de Lista de Comentarios -->
		                </div>
	                </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-sm-3 col-sm-offset-1">
            <apsocial:FriendList runat="server" ID="FriendList" /> 
        </div>
    </div>
<div id="myModal" class="modal fade" tabindex="-1" role="dialog">
  <div class="modal-dialog">
  <div class="modal-content">
	<div class="modal-header">
		<button type="button" class="close" data-dismiss="modal">×</button>
		<h3 class="modal-title">Heading</h3>
	</div>
	<div class="modal-body">
		
	</div>
	<div class="modal-footer">
		<button class="btn btn-default" data-dismiss="modal">Cerrar</button>
	</div>
   </div>
  </div>
</div>
</asp:Content>
