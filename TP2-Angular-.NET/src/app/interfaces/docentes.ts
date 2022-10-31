import { TiposDeCargo } from "./tipos_cargo";

export interface Docentes {
    ID:number,
    Cargo:TiposDeCargo,
    NombreDocente:string,
    CursoID:number,
    // DocenteID?:number

}
