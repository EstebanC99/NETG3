import { Condiciones } from "./condiciones";

export interface Alumno {
    ID:number,
    Legajo:number,
    Nombre:string,
    Apellido:string,
    Descripcion:string|null,
    Condicion?:Condiciones,
    Nota?:number|null,
}
