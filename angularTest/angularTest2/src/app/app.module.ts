import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { ProductComponentComponent } from './product-component/product-component.component';
import { CustomerComponentComponent } from './customer-component/customer-component.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponentComponent,
    CustomerComponentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
