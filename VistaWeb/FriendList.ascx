<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FriendList.ascx.cs" Inherits="VistaWeb.FriendList" %>
<asp:Repeater ID="AmigosList" runat="server">
    <HeaderTemplate>
        <div class="row">
            <h3>Amigos</h3>
        </div>
    </HeaderTemplate>
    <ItemTemplate>
	    <div class="row">
		    <div class="btn-group pull-right">
                <img class="img-responsive img-rounded app-user-list" src="<%# Eval("foto_usuario") %>" alt="Imagen" />
		    </div>
			<p><%# Eval("FullName")%></p>
	    </div>
    </ItemTemplate>
    <FooterTemplate>
    </FooterTemplate>
</asp:Repeater>
