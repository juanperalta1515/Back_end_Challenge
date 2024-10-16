import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

//Para trabajar con Reactive forms
import { ReactiveFormsModule } from '@angular/forms';

//Peticiones Http
import { HttpClientModule } from '@angular/common/http';
//controles de formulario
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatButtonModule} from '@angular/material/button';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import { MatNativeDateModule } from '@angular/material/core';
import { MomentDateModule } from '@angular/material-moment-adapter';
//Mensajes de alerta
import {MatSnackBarModule} from '@angular/material/snack-bar';
//iconos de material
import {MatIconModule} from '@angular/material/icon';
//Modales de material
import {MatDialogModule} from '@angular/material/dialog';
import { from } from 'rxjs';
//cuadriculas
import {MatGridListModule} from '@angular/material/grid-list';
import { DialogAddEditComponent } from './Dialogs/dialog-add-edit/dialog-add-edit.component'

@NgModule({
  declarations: [
    AppComponent,
    DialogAddEditComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatButtonModule,
    MatTableModule,
    MatPaginatorModule,
    MatNativeDateModule,
    MatDatepickerModule,
    MatSelectModule,
    MatInputModule,
    MatFormFieldModule,
    MomentDateModule,
    MatIconModule,
    MatSnackBarModule,
    MatDialogModule,
   MatGridListModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
