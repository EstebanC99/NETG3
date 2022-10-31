import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Planes } from 'src/app/interfaces/planes';
import { TiposDePersona } from 'src/app/interfaces/tipos_persona';
import { PersonasComponent } from './personas/personas.component';

@Component({
  selector: 'app-planes',
  templateUrl: './planes.component.html',
  styleUrls: ['./planes.component.scss'],
})
export class PlanesComponent implements OnInit {
  constructor(private dialog: MatDialog) {}

  listaPlanesDefault: Planes[] = [
    {
      PlanID: 1,
      PlanDescripcion: '2008',
      EspecialidadID: 1,
      Especialidad: {
        ID: 1,
        Descripcion: 'Ingenieria en sistemas',
      },
      Comisiones: [
        {
          ID: 1,
          PlanID: 1,
          AnioEspecialidad: 3,
          Descripcion: 'descripcion comision1',
        },
        {
          ID: 2,
          PlanID: 2,
          AnioEspecialidad: 3,
          Descripcion: 'descripcion comision2',
        },
      ],
      Materias: [
        {
          Descripcion: 'Descripcion Materia 1',
          HsSemanales: 20,
          HsTotates: 100,
          ID: 1,
          CursosMateria: [
            {
              ID: 1,
              Cupo: 20,
              AnioCalendario: 2022,
              ComisionDescripcion: 'descripcion comision1',
              ComisionID: 1,
              Docentes: [],
              Inscriptos: [],
            },
          ],
        },
      ],
      Personas: [
        {
          Apellido: 'Medina',
          Nombre: 'Daniel',
          Direccion: 'Direccion',
          Email: 'DanielMedina012@gmail.com',
          FechaNacimiento: '14/11/1998',
          ID: 1,
          Legajo: '46468',
          PlanID: 1,
          Telefono: '464687646',
          TipoPersona: TiposDePersona.Alumno,
        },
        {
          Apellido: 'Ruiz',
          Nombre: 'Juan',
          Direccion: 'Direccion',
          Email: 'RuizJuan012@gmail.com',
          FechaNacimiento: '14/05/1998',
          ID: 2,
          Legajo: '46467',
          PlanID: 1,
          Telefono: '44444444',
          TipoPersona: TiposDePersona.Alumno,
        },
      ],
    },
  ];

  listaPlanes: Planes[] = [];

  ngOnInit(): void {
    this.listaPlanes = this.listaPlanesDefault;
  }

  openDialogMaterias(plan: Planes) {
    this.dialog.open(PersonasComponent, {
      width: '130vh',
      data: plan,
    });
  }
  openDialogComisiones(plan: Planes) {
    this.dialog.open(PersonasComponent, {
      width: '130vh',
      data: plan,
    });
  }
  openDialogPersonas(plan: Planes) {
    this.dialog.open(PersonasComponent, {
      width: '130vh',
      data: plan,
    });
  }
  search(event: HTMLInputElement) {
    if (event.value == '') {
      this.listaPlanes = this.listaPlanesDefault;
    } else {
      this.listaPlanes = this.listaPlanesDefault.filter((plan) => {
        return plan.PlanDescripcion.toLowerCase().includes(
          event.value.toLowerCase()
        );
      });
    }
  }
}
