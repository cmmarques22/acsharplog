import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from './products.component';
import { CreateProductComponent } from './create-product/create-product.component';
import { ListProductsComponent } from './list-products/list-products.component';

const routes: Routes = [{ path: '', component: ProductsComponent },
{path: 'list-products', component: ListProductsComponent},
{path: 'create-product', component: CreateProductComponent},
{path: 'read-product', component: CreateProductComponent},
{path: 'delete-product', component: CreateProductComponent},


];

// const routes: Routes = [ 
//   { path: '', component: FamiliesComponent }, 
//   { path: 'list-po', component: ListFamiliesComponent }, 
//   { path: 'create-family', component: CreateFamilyComponent }, 
//   { path: 'read-family', component: ReadFamilyComponent } ,
//   { path: 'update-family', component: UpdateFamilyComponent } ,
//   { path: 'delete-family', component: DeleteFamilyComponent } ,
//  ]; 

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductsRoutingModule { }
