<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Areas/Alumno.Master" CodeBehind="AlumnoMainForm.aspx.cs" Inherits="Academia.UI.WebForm.Alumnos.AlumnoMainForm" %>

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
                                <b>Cupo: </b><%# Item.Cupo %>
                            </p>
                            <button type="button"
                                class="btn btn-primary popover-dismiss"
                                data-toggle="popover"
                                title="<%# Item.MateriaDescripcion %>"
                                data-content='<%# 
                                    string.Format("El curso es dictado por el/la profesor/a {0} en la comisión {1}. " +
                                    "Consta de {2}hs semanales y suma un total de {3}hs anuales. " +
                                    "Corresponde a la carrera {4} y al {5}", 
                                    Item.ProfesorNombreApellido,
                                    Item.ComisionDescripcion,
                                    Item.HsSemanales,
                                    Item.HsAnuales,
                                    Item.EspecialidadDescripcion,
                                    Item.PlanDescripcion) %>'
                                data-placement="bottom">Ver detalle</button>
                            <asp:LinkButton CommandName="Desmatricularse" 
                                CommandArgument="<%# Item.ID %>" 
                                OnCommand="Desmatricularse" 
                                CssClass="btn btn-danger" 
                                OnClientClick="return confirm('¿Seguro desea desmatricularse del curso?')" 
                                runat="server">Desmatricularse</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </ItemTemplate>

        </asp:Repeater>
    
    </div>
    </form>
    <script>
        $(function () {
            $('[data-toggle="popover"]').popover()
        });
        $('.popover-dismiss').popover({
            trigger: 'focus'
        });
    </script>

</asp:Content>
