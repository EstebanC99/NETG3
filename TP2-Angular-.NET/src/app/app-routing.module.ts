import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { LoggerUserGuard } from './guards/logger-user.guard';
import { IndexComponent } from './shared/index/index.component';
import { InicioComponent } from './views/inicio/inicio.component';
import { LoginComponent } from './views/login/login.component';
import { LoginModule } from './views/login/login.module';
import { RegisterComponent } from './views/register/register.component';

const routes: Routes = [
  {
    path: 'login',
    component: LoginComponent,
    canActivate: [LoggerUserGuard],
  },
  {
    path: 'register',
    component: RegisterComponent,
    canActivate: [LoggerUserGuard],
  },
  {
    path: '',
    component: IndexComponent,
    canActivateChild: [AuthGuard],
    children: [
      { path: '', redirectTo: 'inicio', pathMatch: 'full' },
      {
        path: 'inicio',
        loadChildren: () =>
          import('./views/inicio/inicio.module').then((m) => m.InicioModule),
      },
      {
        path: 'inscripciones',
        loadChildren: () =>
          import('./views/inscripciones/inscripciones.module').then(
            (m) => m.InscripcionesModule
          ),
      },
      {
        path: 'cursos',
        loadChildren: () =>
          import('./views/cursos/cursos.module').then((m) => m.CursosModule),
      },
      {
        path: 'planes',
        loadChildren: () =>
          import('./views/planes/planes.module').then((m) => m.PlanesModule),
      },
    ],
  },
  {
    path: '**',
    redirectTo: 'inicio',
    pathMatch:"full"
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes), LoginModule],
  exports: [RouterModule],
})
export class AppRoutingModule {}
