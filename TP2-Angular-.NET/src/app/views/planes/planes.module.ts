import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PlanesComponent } from './planes.component';
import { PlanesRoutingModule } from './planes.routing.module';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatChipsModule } from '@angular/material/chips';
import { MatDialogModule } from '@angular/material/dialog';
import { PersonasModule } from './personas/personas.module';



@NgModule({
  declarations: [PlanesComponent],
  imports: [
    CommonModule,
    PlanesRoutingModule,
    MatCardModule,
    MatButtonModule,
    MatChipsModule,
    MatDialogModule,
    PersonasModule
  ]
})
export class PlanesModule { }
