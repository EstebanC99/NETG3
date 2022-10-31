import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Cursos } from 'src/app/interfaces/cursos';
import { TiposDeCargo } from 'src/app/interfaces/tipos_cargo';
import { CursosService } from 'src/app/services/cursos/cursos.service';
import { InscriptosComponent } from './inscriptos/inscriptos.component';

// export const listaCursosDefault: Cursos[] = [
//   {
//     ID: 1,
//     AnioCalendario: 2022,
//     Cupo: 20,
//     MateriaID: 1,
//     MateriaDescripcion: 'Materia1',
//     ComisionDescripcion: 'Prueba',
//     ComisionID: 1,
//     EstaInscripto: true,
//     Plan:{
//       PlanID:1,
//       PlanDescripcion: '2008',
//       EspecialidadID:1
//     },
//     Docentes: [
//       {
//         ID: 1,
//         NombreDocente: 'Juan Diego',
//         CursoID: 1,
//         Cargo: TiposDeCargo.Docente,
//       },
//       {
//         ID: 2,
//         NombreDocente: 'Luis Perez',
//         CursoID: 1,
//         Cargo: TiposDeCargo.Ayudante,
//       },
//     ],
//     Inscriptos: [
//       {
//         AlumnoID: 1,
//         CursoID: 1,
//         NombreAlumno: 'Daniel Medina',
//         Condicion:'Cursando',
//         Nota:8
//       },
//       {
//         AlumnoID: 2,
//         CursoID: 1,
//         NombreAlumno: 'Esteban Carignani',
//         Condicion:'Aprobado',
//         Nota:9
//       },
//     ],
//   },
//   {
//     ID: 2,
//     AnioCalendario: 2022,
//     Cupo: 30,
//     MateriaID: 2,
//     MateriaDescripcion:'Materia1',
//     ComisionDescripcion: 'Comision 405',
//     ComisionID: 2,
//     EstaInscripto: true,
//     Plan:{
//       PlanID:1,
//       PlanDescripcion: '2008',
//       EspecialidadID:1
//     },
//     Docentes: [
//       {
//         ID: 1,
//         NombreDocente: 'Juan Diego',
//         CursoID: 1,
//         Cargo: TiposDeCargo.Docente,
//       },
//     ],
//     Inscriptos: [],
//   },
//   {
//     ID: 3,
//     AnioCalendario: 2022,
//     Cupo: 20,
//     MateriaID: 3,
//     MateriaDescripcion: 'Materia1',
//     ComisionDescripcion: 'Comision 405',
//     ComisionID: 3,
//     EstaInscripto: true,
//     Plan:{
//       PlanID:1,
//       PlanDescripcion: '2008',
//       EspecialidadID:1
//     },
//     Docentes: [
//       {
//         ID: 3,
//         NombreDocente: 'Pepito God',
//         CursoID: 3,
//         Cargo: TiposDeCargo.Docente,
//       },
//     ],
//     Inscriptos: [],
//   },
// ];
@Component({
  selector: 'app-cursos',
  templateUrl: './cursos.component.html',
  styleUrls: ['./cursos.component.scss'],
})
export class CursosComponent implements OnInit {
  constructor(private dialog: MatDialog, private cursosService:CursosService) {}


  listaCursos: Cursos[] = [];
  listaCursosDefault:Cursos[]=[]
  ngOnInit(): void {
    // this.listaCursos = listaCursosDefault;
    this.cursosService.getCursos().subscribe((res)=>{
      this.listaCursos=res;
      this.listaCursosDefault=res;
    })
  }

  openDialog(curso: Cursos): void {
    this.dialog.open(InscriptosComponent, {
      width: '130vh',
      data: curso,
    });
  }

  search(event: HTMLInputElement) {
    if (event.value==""){
      this.listaCursos=this.listaCursosDefault;
    }else{
      this.listaCursos = this.listaCursosDefault.filter((curso) => {
        return curso.MateriaDescripcion.toLowerCase().includes(event.value.toLowerCase());
      });
    }
  }
}
