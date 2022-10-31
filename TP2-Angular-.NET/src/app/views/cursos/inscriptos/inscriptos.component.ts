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

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}
const ELEMENT_DATA: PeriodicElement[] = [
  { position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H' },
  { position: 2, name: 'Helium', weight: 4.0026, symbol: 'He' },
  { position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li' },
  { position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be' },
  { position: 5, name: 'Boron', weight: 10.811, symbol: 'B' },
  { position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C' },
  { position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N' },
  { position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O' },
  { position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F' },
  { position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne' },
];

@Component({
  selector: 'app-inscriptos',
  templateUrl: './inscriptos.component.html',
  styleUrls: ['./inscriptos.component.scss'],
})
export class InscriptosComponent implements OnInit, AfterViewInit {
  curso: Cursos = {} as Cursos;
  // displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  displayedColumns: string[] = ['Legajo', 'Nombre', 'Apellido', 'Nota', 'Condicion'];
  // dataSource : MatTableDataSource<PeriodicElement>;
  dataSource : MatTableDataSource<Alumno>;
  inscriptos:ReporteCurso={} as ReporteCurso;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    public dialogRef: MatDialogRef<InscriptosComponent>,
    private cursosService:CursosService,
    @Inject(MAT_DIALOG_DATA) curso: Cursos
  ) {
    // this.curso = data;
    this.dataSource= new MatTableDataSource(this.inscriptos.Alumnos);
    cursosService.leerAlumnosInscriptos(curso.ID).subscribe((res)=>{
      this.inscriptos= res
      this.dataSource= new MatTableDataSource(this.inscriptos.Alumnos);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    })
  }
  ngOnInit(): void {  
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  aplicarFiltro(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
