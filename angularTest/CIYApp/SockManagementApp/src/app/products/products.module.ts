import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductsRoutingModule } from './products-routing.module';
import { ProductsComponent } from './products.component';
import { ListProductsComponent } from './list-products/list-products.component';
import { CreateProductComponent } from './create-product/create-product.component';
import { UpdateProductComponent } from './update-product/update-product.component';
import { ReadProductComponent } from './read-product/read-product.component';
import { DeleteProductComponent } from './delete-product/delete-product.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    ProductsComponent,
    ListProductsComponent,
    CreateProductComponent,
    UpdateProductComponent,
    ReadProductComponent,
    DeleteProductComponent
  ],
  imports: [
    CommonModule,
    ProductsRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class ProductsModule { }
