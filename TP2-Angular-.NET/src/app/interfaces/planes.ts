import { Comisiones } from "./comisiones";
import { Cursos } from "./cursos";
import { Especialidades } from "./especialidades";
import { Materias } from "./materias";
import { Personas } from "./personas";

export interface Planes {
    PlanID:number,
    PlanDescripcion:string,
    EspecialidadID:number,
    Especialidad?:Especialidades,
    Materias?:Materias[],
    Personas?: Personas[],
    Comisiones?:Comisiones[]
}
export interface Plan {
    PlanID:number,
    PlanDescripcion:string,
    Cursos:Cursos[];
}
