import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InscripcionesComponent } from './inscripciones.component';

const routes: Routes = [
  {
    path: '',
    component: InscripcionesComponent,
    data: {
      title: 'inscripciones',
    },
    children: [
      {
        path: 'crear',
        component: InscripcionesComponent,
        data: {
          title: 'inscripciones1',
        },
      },
      {
        path: 'listar',
        component: InscripcionesComponent,
        data: {
          title: 'inscripciones2',
        },
      },
      {
        path: ':id/editar',
        component: InscripcionesComponent,
        data: {
          title: 'inscripciones3',
        },
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class InscripcionesRoutingModule {}
export const routingComponents = [
  InscripcionesComponent,
];
