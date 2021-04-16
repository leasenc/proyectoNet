<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Canal.aspx.cs" Inherits="Canales_CRM.CrearCanal" MasterPageFile="~/Encabezado.Master" %>

<asp:Content ID="ContenedorCanal" runat="server" ContentPlaceHolderID="body">

    <form id="form1" runat="server">
    <div style="height: 352px; width: 254px">
    
        <table style="width: 132%; height: 190px;">
            <tr>
                <td>
    
                    <asp:Label ID="lblListadoObjetivos" runat="server" Text="CANAL"></asp:Label>
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
    
        <asp:Label ID="Label1" runat="server" Text="Nombre Canal"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtNombre" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label2" runat="server" Text="Medio"></asp:Label>
                </td>
                <td>
        <asp:DropDownList ID="Medio_DD" runat="server" Width="168px" >
            <asp:ListItem Value="1">Escrito</asp:ListItem>
            <asp:ListItem Value="2">Mail</asp:ListItem>
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label4" runat="server" Text="Responsable"></asp:Label>
                </td>
                <td>
        <asp:DropDownList ID="ddlResponsable" runat="server" Width="169px">
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label5" runat="server" Text="Backup Responsable"></asp:Label>
                </td>
                <td>
        <asp:DropDownList ID="ddlBackupResponsable" runat="server" Width="169px" >
        </asp:DropDownList>
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
        <asp:Button ID="OK_btn" class="button" runat="server" Text="Guardar" Width="58px" />
                </td>
                <td>
        <asp:Button ID="Cancel_btn" class="button" runat="server" Text="Cancelar" onclick="Cancel_btn_Click" />
    
                </td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>

</asp:Content>
