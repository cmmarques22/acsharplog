import { Component } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent {



    currentComponentProduct: string = "none";
  
    openComponentProduct(hyperlinkProduct: any) {
      if(hyperlinkProduct) {
        if(hyperlinkProduct.id == "list") {
          this.currentComponentProduct = "list-products";
        }
        else if(hyperlinkProduct.id == "create") {
          this.currentComponentProduct = "create-product";
        }
        else if(hyperlinkProduct.id == "update") {
          this.currentComponentProduct = "update-product";
        }
        else if(hyperlinkProduct.id == "read") {
          this.currentComponentProduct = "read-product";
        }
        if(hyperlinkProduct.id == "delete") {
          this.currentComponentProduct = "delete-product";
        }
        else 
          this.currentComponentProduct = "";
      }
    }
  
  }

