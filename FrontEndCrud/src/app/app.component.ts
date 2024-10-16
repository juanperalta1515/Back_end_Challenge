import {AfterViewInit, Component, ViewChild, OnInit} from '@angular/core';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';
import { Empleado } from './Interfaces/empleado';
import { EmpleadoService } from './Services/empleado.service';
import {
  MatDialog,
  MatDialogActions,
  MatDialogClose,
  MatDialogContent,
  MatDialogTitle,
} from '@angular/material/dialog';
import { DialogAddEditComponent } from './Dialogs/dialog-add-edit/dialog-add-edit.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements AfterViewInit, OnInit {
  displayedColumns: string[] = ['NombreCompleto', 'Departamento', 'Sueldo', 'FechaContrato', 'Acciones'];
  dataSource = new MatTableDataSource<Empleado>();
  constructor (
    private _empleadoServicio:EmpleadoService,
    public dialog:MatDialog
  ){

  }

ngOnInit(): void {
    this.mostrarEmpleados();
}
  @ViewChild(MatPaginator) paginator!: MatPaginator;


  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
}
applyFilter(event: Event) {
  const filterValue = (event.target as HTMLInputElement).value;
  this.dataSource.filter = filterValue.trim().toLowerCase();
}
mostrarEmpleados(){
  this._empleadoServicio.getList().subscribe({
    next:(dataResponse)=>{
      console.log(dataResponse)
      this.dataSource.data=dataResponse;
    },error:(e)=>{}
  })
}

openDialog() {
  this.dialog.open(DialogAddEditComponent);
}

}
export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

