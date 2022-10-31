import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CursosComponent } from './cursos.component';
import { CursosRoutingModule, routingComponents } from './cursos.routing.module';
import {MatCardModule} from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import {MatChipsModule} from '@angular/material/chips';
import {MatDialogModule} from '@angular/material/dialog';
import { InscriptosModule } from './inscriptos/inscriptos.module';


@NgModule({
  declarations: [routingComponents],
  imports: [
    CommonModule,
    CursosRoutingModule,
    MatCardModule,
    MatButtonModule,
    MatChipsModule,
    MatDialogModule,
    InscriptosModule
  ]
})
export class CursosModule { }
