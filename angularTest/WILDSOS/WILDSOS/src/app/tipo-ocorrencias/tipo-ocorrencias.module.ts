import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TipoOcorrenciasRoutingModule } from './tipo-ocorrencias-routing.module';
import { TipoOcorrenciasComponent } from './tipo-ocorrencias.component';
import { CreateTipoOcorrenciaComponent } from './create-tipo-ocorrencia/create-tipo-ocorrencia.component';
import { UpdateTipoOcorrenciaComponent } from './update-tipo-ocorrencia/update-tipo-ocorrencia.component';
import { ReadTipoOcorrenciaComponent } from './read-tipo-ocorrencia/read-tipo-ocorrencia.component';
import { DeleteTipoOcorrenciaComponent } from './delete-tipo-ocorrencia/delete-tipo-ocorrencia.component';
import { ListTipoOcorrenciasComponent } from './list-tipo-ocorrencias/list-tipo-ocorrencias.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
// import { HomeComponent } from '../home/home.component';


@NgModule({
  declarations: [
    TipoOcorrenciasComponent,
    CreateTipoOcorrenciaComponent,
    UpdateTipoOcorrenciaComponent,
    ReadTipoOcorrenciaComponent,
    DeleteTipoOcorrenciaComponent,
    ListTipoOcorrenciasComponent 
  ],
  imports: [
    CommonModule,
    TipoOcorrenciasRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    
  ]
})
export class TipoOcorrenciasModule { }
