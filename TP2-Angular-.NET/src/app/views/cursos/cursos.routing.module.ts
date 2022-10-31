import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CursosComponent } from './cursos.component';

const routes: Routes = [
  {
    path: '',
    component: CursosComponent,
    data: {
      title: 'inscripciones',
    },
    children: [
      {
        path: 'crear',
        component: CursosComponent,
        data: {
          title: 'inscripciones1',
        },
      },
      {
        path: 'listar',
        component: CursosComponent,
        data: {
          title: 'inscripciones2',
        },
      },
      {
        path: ':id/editar',
        component: CursosComponent,
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
export class CursosRoutingModule {}
export const routingComponents = [
  CursosComponent,
];
