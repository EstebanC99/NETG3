import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TiposRoles } from 'src/app/interfaces/tipos_roles';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit {

  constructor(private router: Router) { }
  showFiller = false;
  role=localStorage.getItem('role');
  tipoRol= TiposRoles;
  ngOnInit(): void {
  }

  logOut(){
    localStorage.removeItem('usuario');
    localStorage.removeItem('token');
    localStorage.removeItem('role');
    this.router.navigate(['/login']);
  }
}
