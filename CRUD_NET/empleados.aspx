<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="empleados.aspx.cs" Inherits="CRUD_NET.empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    <asp:Label ID="lbl_codigo" runat="server" Text="Codigo" CssClass="badge" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txt_codigo" runat="server" CssClass="form-control" placeholder="Ejemplo: E001"></asp:TextBox>
    <asp:Label ID="lbl_nombres" runat="server" Text="Nombres" CssClass="badge" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txt_nombres" runat="server" CssClass="form-control" placeholder="Nombre 1 Nombre 2"></asp:TextBox>
    <asp:Label ID="lbl_apellidos" runat="server" Text="Apellidos" CssClass="badge" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txt_apellidos" runat="server" CssClass="form-control" placeholder="Apellido 1 Apellido 2"></asp:TextBox>
    <asp:Label ID="lbl_direccion" runat="server" Text="Direccion" CssClass="badge" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txt_direccion" runat="server" CssClass="form-control" placeholder="Ejemplo: #casa avenida"></asp:TextBox>
    <asp:Label ID="lbl_telefono" runat="server" Text="Telefono" CssClass="badge" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txt_telefono" runat="server" CssClass="form-control" placeholder="12345678"></asp:TextBox>
    <asp:Label ID="lbl_fn" runat="server" Text="Fecha Nacimiento" CssClass="badge" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txt_fn" runat="server" CssClass="form-control" placeholder="Nombre 1 Nombre 2" TextMode="Date"></asp:TextBox>
    <asp:Label ID="lbl_puesto" runat="server" Text="Puesto" CssClass="badge" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <asp:DropDownList ID="drop_puesto" runat="server" CssClass="form-control"></asp:DropDownList>
    <br/>
    <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass="btn btn-info btn-lg" OnClick="btn_agregar_Click" />
    <asp:Button ID="btn_modificar" runat="server" Text="Modificar" CssClass="btn btn-success btn-lg" OnClick="btn_modificar_Click" Visible="False"/>
    <br />
    <br />
    <asp:GridView ID="grid_empleados" runat="server" AutoGenerateColumns="False" CssClass="table-condensed" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="id,id_puesto" OnRowDeleting="grid_epleados_RowDeleting">
        <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btn_selec" runat="server" CausesValidation="False" CommandName="Select" Text="Ver" CssClass="btn btn-info" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btn_eliminar" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" CssClass="btn btn-danger " OnClientClick="javascript:if(!confirm('¿Desea Eliminar?'))return false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="fecha_nacimiento" DataFormatString="{0:d}" HeaderText="Nacimiento" />
                <asp:BoundField DataField="puesto" HeaderText="Puesto" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
