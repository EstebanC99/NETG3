import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Cursos } from 'src/app/interfaces/cursos';
import { Plan, Planes } from 'src/app/interfaces/planes';
import { ReporteCurso } from 'src/app/interfaces/reporte_curso';
import { BaseService } from '../base/base.service';

const baseInscriptos = 'InscripcionCurso';
const baseReporte = 'ReporteCurso';
@Injectable({
  providedIn: 'root',
})
export class CursosService {
  constructor(private http: HttpClient, private baseService: BaseService) {}

  getCursos(extras?: { [key: string]: string }): Observable<Cursos[]> {
    return this.baseService.getAll(baseInscriptos + '/LeerCursos');
  }
  getCursosConCupos(extras?: { [key: string]: string }): Observable<Cursos[]> {
    return this.baseService.getAll(
      baseInscriptos + '/LeerCursosConCuposRestantes'
    );
  }

  leerAlumnosInscriptos(
    idCurso: number,
    extras?: { [key: string]: string }
  ): Observable<ReporteCurso> {
    return this.baseService.getAll(
      baseReporte + '/' + idCurso + '/LeerAlumnosInscriptos'
    );
  }
  getCursosAlumnosLogueado(extras?: {
    [key: string]: string;
  }): Observable<Cursos[]> {
    return this.baseService.getAll(
      baseInscriptos + '/LeerCursosPorAlumnoLogueado'
    );
  }
  inscripcionCurso(
    cursoID: number,
    extras?: { [key: string]: string }
  ): Observable<any> {
    return this.baseService.postOne(baseInscriptos + '/Inscribirse', {
      cursoID: cursoID,
    });
  }
  desmatriculacionCurso(
    curso: Cursos,
    extras?: { [key: string]: string }
  ): Observable<any> {
    return this.baseService.postOne(baseInscriptos + '/Desmatricularse', {
      ID: curso.ID,
      AnioCalendario: curso.AnioCalendario,
      MateriaID: curso.MateriaID,
      ComisionID: curso.ComisionID,
    });
  }

  dividirCursosPorPlan(cursos: Observable<Cursos[]>) {
    return cursos.pipe(
      map((val) => {
        let planes: Plan[] = [];
        let planesID: { PlanID: number; PlanDescripcion: string }[] = [];
        let cursos: Array<Cursos[]> = [];
        val.forEach((cur) => {
          if (
            planesID.filter((plan) => plan.PlanID === cur.PlanID).length == 0
          ) {
            planesID.push({
              PlanID: cur.PlanID,
              PlanDescripcion: cur.PlanDescripcion,
            });
            cursos.push([]);
          }
          const index = planesID.findIndex((plan) => cur.PlanID == plan.PlanID);
          cursos[index].push(cur);
        });
        for (let i = 0; i < planesID.length; i++) {
          {
            planes.push({
              PlanID: planesID[i].PlanID,
              PlanDescripcion: planesID[i].PlanDescripcion,
              Cursos: cursos[i],
            });
          }
        }
        return planes;
      })
    );
  }
}
