import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TipoOcorrenciasComponent } from './tipo-ocorrencias.component';

import { ListTipoOcorrenciasComponent } from './list-tipo-ocorrencias/list-tipo-ocorrencias.component';
import { CreateTipoOcorrenciaComponent } from './create-tipo-ocorrencia/create-tipo-ocorrencia.component';
import { ReadTipoOcorrenciaComponent } from './read-tipo-ocorrencia/read-tipo-ocorrencia.component';
import { UpdateTipoOcorrenciaComponent } from './update-tipo-ocorrencia/update-tipo-ocorrencia.component';
import { DeleteTipoOcorrenciaComponent } from './delete-tipo-ocorrencia/delete-tipo-ocorrencia.component';




const routes: Routes = [{ path: '', component: TipoOcorrenciasComponent },
{ path: '', component: TipoOcorrenciasComponent },
{ path: 'list-tipo-ocorrencias', component: ListTipoOcorrenciasComponent },
{ path: 'create-tipo-ocorrencia', component: CreateTipoOcorrenciaComponent },
{ path: 'read-tipo-ocorrencia/:id', component: ReadTipoOcorrenciaComponent },
{ path: 'update-tipo-ocorrencia/:id', component: UpdateTipoOcorrenciaComponent },
{ path: 'delete-tipo-ocorrencia/:id', component: DeleteTipoOcorrenciaComponent }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TipoOcorrenciasRoutingModule { }
