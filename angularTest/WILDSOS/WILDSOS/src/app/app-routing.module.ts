import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DeleteTipoOcorrenciaComponent } from './tipo-ocorrencias/delete-tipo-ocorrencia/delete-tipo-ocorrencia.component';
import { ReadTipoOcorrenciaComponent } from './tipo-ocorrencias/read-tipo-ocorrencia/read-tipo-ocorrencia.component';
import { ListTipoOcorrenciasComponent } from './tipo-ocorrencias/list-tipo-ocorrencias/list-tipo-ocorrencias.component';
import { CreateTipoOcorrenciaComponent } from './tipo-ocorrencias/create-tipo-ocorrencia/create-tipo-ocorrencia.component';
import { EspeciesComponent } from './especies/especies.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'especies', loadChildren: () => import('./especies/especies.module').then(m => m.EspeciesModule) },
 { path: 'tiposOcorrencias', loadChildren: () => import('./tipo-ocorrencias/tipo-ocorrencias.module').then(m => m.TipoOcorrenciasModule) },
 { path: 'delete-tipo-ocorrencia/:idTipoOcorrencia', component: DeleteTipoOcorrenciaComponent },
 { path: 'read-tipo-ocorrencia/:idTipoOcorrencia', component: ReadTipoOcorrenciaComponent },
 //html
 { path: 'list-tipo-ocorrencia', component: ListTipoOcorrenciasComponent },
 { path: 'create-tipo-ocorrencia', component: CreateTipoOcorrenciaComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }