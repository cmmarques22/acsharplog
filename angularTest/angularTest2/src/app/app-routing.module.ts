import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponentComponent } from './product-component/product-component.component';
import { CustomerComponentComponent } from './customer-component/customer-component.component';
const routes: Routes = [
  {path: 'products', component: ProductComponentComponent},
  {path: 'customers/:id', component: CustomerComponentComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
