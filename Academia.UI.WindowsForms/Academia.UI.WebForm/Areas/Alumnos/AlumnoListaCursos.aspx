<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Areas/Alumno.Master" CodeBehind="AlumnoListaCursos.aspx.cs" Inherits="Academia.UI.WebForm.Areas.Alumnos.AlumnoListaCursos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AlumnoContent" runat="server">

    <div class="container" style="padding-top: 100px;">
    
        <div class="container mt-3">
            <h2>Cursos</h2>
            <p>Ingrese el nombre del curso al que desee inscribirse:</p>  
            <input class="form-control" id="cursoFiltro" type="text" placeholder="Buscar..">
            <br>

            <form runat="server" method="post">
                <table class="table table-bordered">
                    <thead>
                      <tr>
                        <th>Materia</th>
                        <th>Año</th>
                        <th>Comision</th>
                        <th>Cupos disponibles</th>
                        <th></th>
                      </tr>
                    </thead>
                    <tbody id="myTable">
                        <asp:Repeater ID="RepeaterCursos" runat="server" ItemType="Academia.UI.ViewModels.CursoVM">
                            <ItemTemplate>
                                    <tr>
                                        <td><%# Item.MateriaDescripcion %></td>
                                        <td><%# Item.AnioCalendario %></td>
                                        <td><%# Item.ComisionDescripcion %></td>
                                        <td class="<%# Item.CuposRestantes == default(int) ? "text-danger" : "text-success" %>"><%# Item.CuposRestantes %></td>
                                        <td>
                                            <asp:Label Text="Inscripto" 
                                                runat="server" 
                                                Visible="<%# Item.EstaInscripto %>"></asp:Label>
                                            <asp:LinkButton CommandName="Inscribirse" 
                                                CommandArgument="<%# Item.ID %>"
                                                Text="Inscribirse"  
                                                runat="server" 
                                                OnCommand="Inscribirse_Command" 
                                                OnClientClick='<%# Item.CuposRestantes > default(int) ? "return confirm(`¿Seguro desea inscribirse?`)" :
                                                    "return alert(`No hay mas cupos disponibles!`)"%>' 
                                                Enabled="<%# (!Item.EstaInscripto && Item.CuposRestantes > default(int)) %>"
                                                Visible="<%# !Item.EstaInscripto %>"
                                                CssClass="link-primary"></asp:LinkButton>
                                        </td>
                                    </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </form>
        </div>

    </div>

    
    <script>
        $(document).ready(function () {
            $("#cursoFiltro").on("keyup", function () {
                var value = $(this).val().toLowerCase();
                $("#myTable tr").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });
        });
    </script>
</asp:Content>
