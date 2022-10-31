import { Alumno } from "./alumnos";
import { Condiciones } from "./condiciones";

export interface ReporteCurso {
	CantidadInscriptos: number,
	CantidadAprobados: number,
	CantidadRegulares: number,
	CantidadLibres: number,
	ID: number,
	Descripcion: string|null,
    Alumnos:Alumno[]
}
