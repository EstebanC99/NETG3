import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app-routing.module';
import { InscripcionesComponent } from './inscripciones/inscripciones.component';
import { PlanesComponent } from './planes/planes.component';
import { CursosComponent } from './cursos/cursos.component';
import { RegisterModule } from './register/register.module';
import { LoginModule } from './login/login.module';
import { PlanesModule } from './planes/planes.module';
import { InscripcionesModule } from './inscripciones/inscripciones.module';
import { InicioModule } from './inicio/inicio.module';



@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    RegisterModule,
    LoginModule,
    PlanesModule,
    InscripcionesModule,
    InicioModule
  ]
})
export class ViewsModule { }
