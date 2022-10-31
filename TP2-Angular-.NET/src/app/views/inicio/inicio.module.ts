import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InicioComponent } from './inicio.component';
import { InicioRoutingModule, routingComponents } from './inicio.routing.module';



@NgModule({
  declarations: [routingComponents],
  imports: [
    CommonModule,
    InicioRoutingModule
  ]
})
export class InicioModule { }
