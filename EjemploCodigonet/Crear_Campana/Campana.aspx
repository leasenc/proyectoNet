<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Campana.aspx.cs" Inherits="Crear_Campana._Default" MasterPageFile="~/Encabezado.Master" %>

<asp:Content ID="ContenedorCampana" runat="server" ContentPlaceHolderID="body">

    <form id="form1" runat="server">
    &nbsp;<table style="width: 50%; height: 346px">
        <tr>
            <td>
        <asp:Label ID="LabelPpal" runat="server" Text="CAMPAÑAS"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
        <asp:Label ID="LabelNombre" runat="server" Text="Nombre Campaña:"></asp:Label>
            </td>
            <td>
        <asp:TextBox ID="TextBoxNombreCampana" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
        <asp:Label ID="LabelArchivoAdjunto" runat="server" Text="Archivo Adjunto"></asp:Label>
            </td>
            <td>
        <asp:TextBox ID="TextBoxRutaAdjunto" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonAdjuntarAdjunto" class="button" runat="server" Text="Adjuntar" />
            </td>
        </tr>
        <tr>
            <td>
        <asp:Label ID="LabelAsunto" runat="server" Text="Asunto Campaña"></asp:Label>
            </td>
            <td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
        <asp:Label ID="LabelObjetivo" runat="server" Text="Objetivo :"></asp:Label>
            </td>
            <td>
        <asp:DropDownList ID="ddlObjetivos" runat="server" 
            style="margin-bottom: 0px" Width="184px">
        </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
        <asp:Label ID="LabelCanal" runat="server" Text="Canal a Usar : "></asp:Label>
            </td>
            <td>
        <asp:DropDownList ID="ddlCanales" runat="server" 
            style="margin-bottom: 0px" Width="184px">
        </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
        <asp:Label ID="LabelCanal0" runat="server" Text="Responsable:"></asp:Label>
            </td>
            <td>
        <asp:DropDownList ID="ddlResponsable" runat="server" Width="169px">
        </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
        <asp:Label ID="LabelTarget" runat="server" Text="Target"></asp:Label>
            </td>
            <td>
        <asp:Button ID="ButtonSeleccionarTarget" class="button" runat="server" Text="Seleccionar" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
        <asp:Button ID="ButtonCrearCampana" class="button" runat="server" Text="Crear" />
            </td>
            <td>
        <asp:Button ID="ButtonLimpiar" class="button" runat="server" onclick="ButtonLimpiar_Click" 
            Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    
    </form>
    
</asp:Content>