<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="VistaWeb.Account.Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Crear una nueva cuenta
    </h2>
    <p>
        Use el formulario siguiente para crear una cuenta nueva.
    </p>
    <span class="failureNotification">
        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
    </span>
    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification" 
            ValidationGroup="RegisterUserValidationGroup"/>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Información de cuenta</legend>
            <p>
                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">Correo electrónico:</asp:Label>
                <asp:TextBox ID="Email" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" 
                        CssClass="failureNotification" ErrorMessage="El correo electrónico es obligatorio." ToolTip="El correo electrónico es obligatorio." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                        CssClass="failureNotification" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." 
                        ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirmar contraseña:</asp:Label>
                <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="ConfirmPassword" CssClass="failureNotification" Display="Dynamic" 
                        ErrorMessage="Confirmar contraseña es obligatorio." ID="ConfirmPasswordRequired" runat="server" 
                        ToolTip="Confirmar contraseña es obligatorio." ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                        CssClass="failureNotification" Display="Dynamic" ErrorMessage="Contraseña y Confirmar contraseña deben coincidir."
                        ValidationGroup="RegisterUserValidationGroup">*</asp:CompareValidator>
            </p>
            <p>
                <asp:Label ID="NombreLabel" runat="server" AssociatedControlID="Nombre">Nombre</asp:Label>
                <asp:TextBox ID="Nombre" runat="server" CssClass="textEntry" TextMode="SingleLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NombreRequired" runat="server" 
                    CssClass="failureNotification" Display="Dynamic" ControlToValidate="Nombre"
                    ErrorMessage="El Nombre es obligatorio" ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p>
                <asp:Label ID="ApellidoLabel" runat="server" AssociatedControlID="Apellido">Apellido</asp:Label>
                <asp:TextBox ID="Apellido" runat="server" CssClass="textEntry" TextMode="SingleLine"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="ResidenciaLabel" runat="server" AssociatedControlID="Residencia">Lugar de Residencia</asp:Label>
                <asp:TextBox ID="Residencia" runat="server" CssClass="textEntry" TextMode="SingleLine"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="FechaDeNacimientoLabel" runat="server" AssociatedControlID="Dia">Fecha de Nacimiento</asp:Label>
                <asp:TextBox ID="Dia" runat="server" Width="32px"></asp:TextBox>
                <asp:DropDownList ID="Mes" runat="server">
                    <asp:ListItem Value="01">Enero</asp:ListItem>
                    <asp:ListItem Value="02">Febrero</asp:ListItem>
                    <asp:ListItem Value="03">Marzo</asp:ListItem>
                    <asp:ListItem Value="04">Abril</asp:ListItem>
                    <asp:ListItem Value="05">Mayo</asp:ListItem>
                    <asp:ListItem Value="06">Junio</asp:ListItem>
                    <asp:ListItem Value="07">Julio</asp:ListItem>
                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                    <asp:ListItem Value="09">Septiembre</asp:ListItem>
                    <asp:ListItem Value="10">Octubre</asp:ListItem>
                    <asp:ListItem Value="11">Noviembre</asp:ListItem>
                    <asp:ListItem Value="12">Diciembre</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="Anio" runat="server" Width="56px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="FotoLabel" runat="server" AssociatedControlID="Foto">Foto</asp:Label>
                <asp:FileUpload ID="Foto" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="Foto" CssClass="failureNotification" Display="Dynamic" 
                    ErrorMessage="Es obligatorio subir una foto" 
                    ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
        </fieldset>
        <p class="submitButton">
            <asp:Button ID="CreateUserButton" runat="server" Text="Crear usuario" 
                    ValidationGroup="RegisterUserValidationGroup"/>
        </p>
    </div>
</asp:Content>
