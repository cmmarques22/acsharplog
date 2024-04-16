// import { NgModule } from '@angular/core';
// import { RouterModule, Routes } from '@angular/router';
// import { HomeComponent } from './home/home.component';


// const routes: Routes = [
//   { path: '', redirectTo: 'home', pathMatch: 'full' },
//   { path: 'home', component: HomeComponent },
//   { path: 'families', loadChildren: () => import('./families/families.module').then(m => m.FamiliesModule) },
//   { path: 'products', loadChildren: () => import('./products/products.module').then(m => m.ProductsModule) }
// ];

// @NgModule({
//   imports: [RouterModule.forRoot(routes)],
//   exports: [RouterModule]
// })
// export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'families', loadChildren: () => import('./families/families.module').then(m => m.FamiliesModule) },
  { path: 'products', loadChildren: () => import('./products/products.module').then(m => m.ProductsModule) },
  // Add the following lines for the new components
  { path: 'families/delete/:id', loadChildren: () => import('./families/families.module').then(m => m.FamiliesModule) },
  { path: 'families/read/:id', loadChildren: () => import('./families/families.module').then(m => m.FamiliesModule) },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
