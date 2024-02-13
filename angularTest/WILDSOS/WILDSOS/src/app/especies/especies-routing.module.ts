import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EspeciesComponent } from './especies.component';
import { ListEspeciesComponent } from './list-especies/list-especies.component';
import { CreateEspecieComponent } from './create-especie/create-especie.component';
import { ReadEspecieComponent } from './read-especie/read-especie.component';
import { UpdateEspecieComponent } from './update-especie/update-especie.component';
import { DeleteEspecieComponent } from './delete-especie/delete-especie.component';

const routes: Routes = [ 
  { path: '', component: EspeciesComponent }, 
  { path: 'list-especies', component: ListEspeciesComponent }, 
  { path: 'create-especie', component: CreateEspecieComponent }, 
  { path: 'read-especie', component: ReadEspecieComponent } ,
  { path: 'update-especie', component: UpdateEspecieComponent } ,
  { path: 'delete-especie', component: DeleteEspecieComponent } ,
 ]; 
 

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EspeciesRoutingModule { }