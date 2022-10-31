import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InscripcionesComponent } from './inscripciones.component';
import { InscripcionesRoutingModule, routingComponents } from './inscripciones.routing.module';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { MatDialogModule } from '@angular/material/dialog';
import {MatDividerModule} from '@angular/material/divider';
import {MatListModule} from '@angular/material/list';
import { FormInscripcionModule } from './formInscripcion/formInscripcion.module';
import {MatSnackBarModule} from '@angular/material/snack-bar';



@NgModule({
  declarations: [routingComponents],
  imports: [
    CommonModule,
    InscripcionesRoutingModule,
    MatButtonModule,
    MatCardModule,
    MatChipsModule,
    MatDialogModule,
    MatDividerModule,
    MatListModule,
    FormInscripcionModule,
    MatSnackBarModule
  ]
})
export class InscripcionesModule { }
