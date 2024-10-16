import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup,Validators}from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { MAT_DATE_FORMATS } from '@angular/material/core';
import * as moment from 'moment';
import { Departamento } from 'src/app/Interfaces/departamento';
import { Empleado } from 'src/app/Interfaces/empleado';
import { DepartamentoService } from 'src/app/Services/departamento.service';
import { EmpleadoService } from 'src/app/Services/empleado.service';
import { from } from 'rxjs';
@Component({
  selector: 'app-dialog-add-edit',
  templateUrl: './dialog-add-edit.component.html',
  styleUrls: ['./dialog-add-edit.component.css']
})
export class DialogAddEditComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
