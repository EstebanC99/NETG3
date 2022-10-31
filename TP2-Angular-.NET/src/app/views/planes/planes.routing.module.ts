import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PlanesComponent } from './planes.component';

const routes: Routes = [
  {
    path: '',
    component: PlanesComponent,
    data: {
      title: 'inscripciones',
    },
    children: [
      {
        path: 'crear',
        component: PlanesComponent,
        data: {
          title: 'inscripciones1',
        },
      },
      {
        path: 'listar',
        component: PlanesComponent,
        data: {
          title: 'inscripciones2',
        },
      },
      {
        path: ':id/editar',
        component: PlanesComponent,
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
export class PlanesRoutingModule {}
export const routingComponents = [
  PlanesComponent,
];
