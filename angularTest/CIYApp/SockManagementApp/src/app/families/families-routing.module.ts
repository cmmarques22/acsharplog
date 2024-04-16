// import { NgModule } from '@angular/core';
// import { RouterModule, Routes } from '@angular/router';
// import { FamiliesComponent } from './families.component';
// import { ListFamiliesComponent } from './list-families/list-families.component';
// import { CreateFamilyComponent } from './create-family/create-family.component';
// import { ReadFamilyComponent } from './read-family/read-family.component';
// import { UpdateFamilyComponent } from './update-family/update-family.component';
// import { DeleteFamilyComponent } from './delete-family/delete-family.component';

// const routes: Routes = [ 
//   { path: '', component: FamiliesComponent }, 
//   { path: 'list-families', component: ListFamiliesComponent }, 
//   { path: 'create-family', component: CreateFamilyComponent }, 
//   { path: 'read-family', component: ReadFamilyComponent } ,
//   { path: 'update-family', component: UpdateFamilyComponent } ,
//   { path: 'delete-family', component: DeleteFamilyComponent } ,
//  ]; 
 

// @NgModule({
//   imports: [RouterModule.forChild(routes)],
//   exports: [RouterModule]
// })
// export class FamiliesRoutingModule { }


import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FamiliesComponent } from './families.component';
import { ListFamiliesComponent } from './list-families/list-families.component';
import { CreateFamilyComponent } from './create-family/create-family.component';
import { ReadFamilyComponent } from './read-family/read-family.component';
import { UpdateFamilyComponent } from './update-family/update-family.component';
import { DeleteFamilyComponent } from './delete-family/delete-family.component';

const routes: Routes = [ 
  { path: '', component: FamiliesComponent }, 
  { path: 'list-families', component: ListFamiliesComponent }, 
  { path: 'create-family', component: CreateFamilyComponent }, 
  { path: 'read-family/:id', component: ReadFamilyComponent }, // Updated route with ':id' parameter
  { path: 'update-family/:id', component: UpdateFamilyComponent }, // Updated route with ':id' parameter
  { path: 'delete-family/:id', component: DeleteFamilyComponent }, // Updated route with ':id' parameter
 ]; 
 

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FamiliesRoutingModule { }

