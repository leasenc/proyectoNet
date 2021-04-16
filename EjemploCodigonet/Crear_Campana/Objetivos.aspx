<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Objetivos.aspx.cs" Inherits="Crear_Campana.Objetivos" 
MasterPageFile="~/Encabezado.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <form runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    <asp:Label ID="lblListadoObjetivos" runat="server" Text="OBJETIVOS"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grvObjetivos" runat="server" AutoGenerateColumns="False" 
                        EmptyDataText="No se encontraron objetivos.">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" />
                            <asp:HyperLinkField DataNavigateUrlFields="Id" 
                                DataNavigateUrlFormatString="~/Objetivo.aspx?var={0}" DataTextField="Nombre" 
                                HeaderText="Nombre" />
                            <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chbDelete" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" CssClass="button" 
                        onclick="Button1_Click" Text="Crear" />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                        Text="Eliminar" CssClass="button" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
 </asp:Content> 