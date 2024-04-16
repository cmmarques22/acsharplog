import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ProductService {
  apiURL: string = "";

  constructor(private httpClient: HttpClient) { 
    this.apiURL = environment.apiUrl + "Products"; }
}

