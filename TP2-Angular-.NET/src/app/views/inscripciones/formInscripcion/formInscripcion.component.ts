import { AfterViewInit, Component, Inject, OnInit, ViewChild } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Alumno } from 'src/app/interfaces/alumnos';
import { AlumnosInscriptos } from 'src/app/interfaces/alumnos_inscriptos';
import { Cursos } from 'src/app/interfaces/cursos';
import { Planes } from 'src/app/interfaces/planes';
import { ReporteCurso } from 'src/app/interfaces/reporte_curso';
import { CursosService } from 'src/app/services/cursos/cursos.service';

@Component({
  selector: 'app-inscriptos',
  templateUrl: './formInscripcion.component.html',
  styleUrls: ['./formInscripcion.component.scss'],
})
export class FormInscripcionComponent implements OnInit {
  curso: Cursos = {} as Cursos;
  displayedColumns: string[] = ['Legajo', 'Nombre', 'Apellido', 'Nota', 'Condicion'];
  // dataSource : MatTableDataSource<PeriodicElement>;
  inscriptos:ReporteCurso={} as ReporteCurso;
  tipo:string;
  constructor(
    public dialogRef: MatDialogRef<FormInscripcionComponent>,
    private cursosService:CursosService,
    @Inject(MAT_DIALOG_DATA) data: {curso:Cursos,tipo:string}
  ) {
    this.curso = data.curso;
    this.tipo=data.tipo;
  }
  ngOnInit(): void {  
  }

}
