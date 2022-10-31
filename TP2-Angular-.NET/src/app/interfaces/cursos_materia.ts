import { AlumnosInscriptos } from "./alumnos_inscriptos";
import { Docentes } from "./docentes";
import { Planes } from "./planes";

export interface CursosMateria {
    ID:Number,
    AnioCalendario:number,
    Cupo:number,
    ComisionID:number,
    ComisionDescripcion:string,
    EstaInscripto?:boolean,
    Docentes?:Docentes[],
    Inscriptos?:AlumnosInscriptos[]
}
