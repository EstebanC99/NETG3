<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Areas/Alumno.Master" CodeBehind="ProfesorMainForm.aspx.cs" Inherits="Academia.UI.WebForm.Areas.Profesores.ProfesorMainForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AlumnoContent" runat="server">

    <form runat="server">
    <div class="row" style="padding-top: 100px;">
        
        <asp:Repeater ID="RepeaterCursos" runat="server" ItemType="Academia.UI.ViewModels.CursoVM">
            <ItemTemplate>
                <div class="col-sm-4">
                    <div class="card" style="width: 18rem;">
                        <div class="card-header">
                            <%# Item.MateriaDescripcion%>
                        </div>
                        <div class="card-body">
                            <p>
                                <b>Año: </b><%# Item.AnioCalendario %>
                                <br />
                                <b>Comisión: </b><%# Item.ComisionDescripcion %>
                                <br />
                                <b>Plan: </b><%# Item.PlanDescripcion %>
                            </p>
                            <asp:LinkButton CommandName="CargarNotas"
                                CommandArgument="<%# Item.ID %>" 
                                OnCommand="CargarNotas" 
                                CssClass="btn btn-primary" 
                                runat="server">Cargar notas</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </ItemTemplate>

        </asp:Repeater>
    
    </div>
    </form>

</asp:Content>
