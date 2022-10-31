import { CursosMateria } from "./cursos_materia";

export interface Materias {
    ID:number,
    Descripcion:string,
    HsSemanales:number,
    HsTotates:number,
    CursosMateria:CursosMateria[],
}
