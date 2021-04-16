<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Objetivo.aspx.cs" Inherits="CrearObjetivos.CrearObj" MasterPageFile="~/Encabezado.Master" %>

<asp:Content ID="ContenedorObjetivo" ContentPlaceHolderID="body" runat="server">

    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="LbObjGral0" runat="server" Text="OBJETIVO"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="LbObjGral2" runat="server" Text="General"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="LbObjGral" runat="server" Text="Descripcion:"></asp:Label>
            </td>
            <td class="style7">
                <asp:TextBox ID="txtGeneral" runat="server" Width="705px"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvGeneral" runat="server" 
                    ControlToValidate="txtGeneral" ErrorMessage="El nombre general es requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="LbObjGral1" runat="server" Text="Valor:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtValor" runat="server" Width="33px" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvValor" runat="server" 
                    ControlToValidate="txtValor" ErrorMessage="El valor general es requerido."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="LbObjGral4" runat="server" Text="Especificos"></asp:Label>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="LbObjGral5" runat="server" Text="1. Descripcion:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtEspecifico1" runat="server" Height="65px" TextMode="MultiLine" 
                    Width="702px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEsp1" runat="server" 
                    ControlToValidate="txtEspecifico1" 
                    ErrorMessage="El nombre del objetivo especifico 1 es requerido."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="LbObjGral6" runat="server" Text="1. Valor:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtValor1" runat="server" Width="32px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvValor1" runat="server" 
                    ControlToValidate="txtValor1" 
                    ErrorMessage="El valor del objetivo especifico 1 es requerido."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="LbObjGral7" runat="server" Text="2. Descripcion:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtEspecifico2" runat="server" Height="60px" TextMode="MultiLine" 
                    Width="698px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="LbObjGral9" runat="server" Text="2. Valor:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtValor2" runat="server" Width="32px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="LbObjGral10" runat="server" Text="3. Descripcion:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtEspecifico3" runat="server" Height="75px" TextMode="MultiLine" 
                    Width="696px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="LbObjGral8" runat="server" Text="3. Valor:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtValor3" runat="server" Width="32px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Button ID="Button1" runat="server" Text="Guardar" 
                    onclick="Button1_Click" />
                </td>
            <td class="style3">
                <asp:Button ID="Button2" runat="server" style="margin-left: 175px" 
                    Text="Cancelar" CausesValidation="False" onclick="Button2_Click" />
            </td>
        </tr>
    </table>
    </form>

</asp:Content>