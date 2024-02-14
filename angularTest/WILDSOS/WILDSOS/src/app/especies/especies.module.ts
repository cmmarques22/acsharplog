import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EspeciesRoutingModule } from './especies-routing.module';
import { EspeciesComponent } from './especies.component';
import { CreateEspecieComponent } from './create-especie/create-especie.component';
import { UpdateEspecieComponent } from './update-especie/update-especie.component';
import { ReadEspecieComponent } from './read-especie/read-especie.component';
import { ListEspeciesComponent } from './list-especies/list-especies.component';
import { DeleteEspecieComponent } from './delete-especie/delete-especie.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    EspeciesComponent,
    CreateEspecieComponent,
    UpdateEspecieComponent,
    ReadEspecieComponent,
    ListEspeciesComponent,
    DeleteEspecieComponent
  ],
  imports: [
    CommonModule,
    EspeciesRoutingModule,
    FormsModule,
    ReactiveFormsModule

  ]
})
export class EspeciesModule {

}
