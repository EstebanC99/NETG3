import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InicioComponent } from './inicio.component';

const routes: Routes = [
  {
    path: '',
    component: InicioComponent,
    data: {
      title: 'Inicio',
    },
    children: [
      {
        path: 'crear',
        component: InicioComponent,
        data: {
          title: 'Inicio1',
        },
      },
      {
        path: 'listar',
        component: InicioComponent,
        data: {
          title: 'Inicio2',
        },
      },
      {
        path: ':id/editar',
        component: InicioComponent,
        data: {
          title: 'Inicio3',
        },
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class InicioRoutingModule {}
export const routingComponents = [
  InicioComponent,
];
