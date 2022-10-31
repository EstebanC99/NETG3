import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AlumnosInscriptos } from 'src/app/interfaces/alumnos_inscriptos';
import { Cursos } from 'src/app/interfaces/cursos';
import { Plan } from 'src/app/interfaces/planes';
import { CursosService } from 'src/app/services/cursos/cursos.service';
import { FormInscripcionComponent } from './formInscripcion/formInscripcion.component';

@Component({
  selector: 'app-inscripciones',
  templateUrl: './inscripciones.component.html',
  styleUrls: ['./inscripciones.component.scss'],
})
export class InscripcionesComponent implements OnInit {
  listaCursos: Cursos[] = [];
  listaPlanes: Plan[] = [];
  listaPlanesDefault: Plan[] = [];
  constructor(
    private dialog: MatDialog,
    private cursosService: CursosService,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    let peticion = this.cursosService.getCursosConCupos();
    this.cursosService.dividirCursosPorPlan(peticion).subscribe((res) => {
      this.listaPlanes = res;
    });
    this.cursosService.dividirCursosPorPlan(peticion).subscribe((res) => {
      this.listaPlanesDefault = res;
    });
    this.cursosService.getCursosAlumnosLogueado().subscribe((res) => {
      console.log(res);
      this.listaCursos = res;
    });
  }

  search(event: HTMLInputElement) {
    if (event.value == '') {
      this.listaPlanes = this.listaPlanesDefault;
      return this.listaPlanes;
    } else {
      for (let index = 0; index < this.listaPlanesDefault.length; index++) {
        const plan = this.listaPlanesDefault[index];
        let cursos = plan.Cursos.filter((curso) => {
          return (
            curso.MateriaDescripcion.toLowerCase().includes(
              event.value.toLowerCase()
            ) ||
            curso.ComisionDescripcion.toLowerCase().includes(
              event.value.toLowerCase()
            )
          );
        });
        this.listaPlanes[index].Cursos = cursos;
      }
      console.log(this.listaPlanesDefault);
      return this.listaPlanes;
    }
  }

  inscribirAlumno(curso: Cursos): void {
    let dialog = this.dialog.open(FormInscripcionComponent, {
      data: { curso: curso, tipo: 'Inscripcion' },
    });
    dialog.afterClosed().subscribe((value) => {
      if (value) {
        this.cursosService.inscripcionCurso(curso.ID).subscribe((res) => {
          if (res) {
            this.openSnackBar(
              'Inscripcion a ' +
                curso.MateriaDescripcion +
                ' en ' +
                curso.ComisionDescripcion +
                ' realizada satisfactoriamente',
              'Cerrar',
              {color:"green-snackbar"}
            );
            this.ngOnInit();
          }
        });
      }
    });
  }
  desmatricularAlumno(curso: Cursos): void {
    let dialog = this.dialog.open(FormInscripcionComponent, {
      data: { curso: curso, tipo: 'Desmatricular' },
    });
    dialog.afterClosed().subscribe((value) => {
      if (value) {
        this.cursosService.desmatriculacionCurso(curso).subscribe((res) => {
          if (res) {
            this.openSnackBar(
              'Desmatriculación de ' +
                curso.MateriaDescripcion +
                ' en ' +
                curso.ComisionDescripcion +
                ' realizada satisfactoriamente',
              'Cerrar', {color:'blue-snackbar'}
            );
            this.ngOnInit();
          }
        });
      }
    });
  }
  estaInscripto(curso: Cursos): boolean {
    if (this.listaCursos.filter((cur) => cur.ID == curso.ID).length > 0) {
      return true;
    } else {
      return false;
    }
  }

  openSnackBar(message: string, action: string, clases:{ [key: string]: string }) {
    this._snackBar.open(message, action, {
      duration: 5000,
      panelClass: Object.values(clases),
    });
  }
}
