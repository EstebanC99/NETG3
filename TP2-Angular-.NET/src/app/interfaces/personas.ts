import { TiposDePersona } from "./tipos_persona";

export interface Personas {
    ID:number,
    Apellido:string,
    Nombre:string,
    Direccion:string,
    Email:string,
    FechaNacimiento:string,
    PlanID:number,
    Legajo:string,
    Telefono:string,
    TipoPersona:TiposDePersona
}
