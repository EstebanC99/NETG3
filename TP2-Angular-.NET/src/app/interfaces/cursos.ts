import { AlumnosInscriptos } from './alumnos_inscriptos';
import { Docentes } from './docentes';
import { Planes } from './planes';

export interface Cursos {
  ID: number;
  Descripcion: string;
  HsSemanales: number;
  HsTotales: number;
  AnioCalendario: number;
  Cupo: number;
  CuposRestantes: number;
  MateriaID: number;
  MateriaDescripcion: string;
  ComisionID: number;
  ComisionDescripcion: string;
  EspecialidadDescripcion: string;
  EspecialidadID: 1;
  EstaInscripto?: boolean;
  CondicionCurso: boolean;
  Nota: number;
  PlanDescripcion: string;
  PlanID: number;
  ProfesorNombreApellido: string;
  

//   Inscriptos?: AlumnosInscriptos[];
//   Docentes?: Docentes[];
//   Plan: Planes;
}
