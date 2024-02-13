import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable, catchError } from 'rxjs';
import { Especie } from './especie';
import { of } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class EspecieService {
  [x: string]: any;
  apiUrl: string = "";

  constructor(private httpClient: HttpClient) {
    this.apiUrl = environment.apiUrl + "Especies";
   };

  //  apiUrl: string = environment.apiUrl + 'Families';  // Adjust the concatenation here

  // constructor(private httpClient: HttpClient) {}

   async getAll(): Promise<Observable<Especie[]>> {
  const data = await this.httpClient.get<Especie[]>(this.apiUrl);
  console.log(data); // Log the received data
  return data;
}

create(especieBody: any): Observable<Especie> {
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  return this.httpClient.post<Especie>(this.apiUrl, especieBody, httpOptions)
    .pipe(
      catchError((error) => {
        console.error(error);
        throw error;
      })
    );
}
  

   update(id: string, body: any): Observable<Especie> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
        //adicione outros cabelçalhos

      })
    };
    return this.httpClient.put<Especie>(this.apiUrl + "/" + id, body, httpOptions);//return an obser

  }

  delete(id:string): Observable<Especie> {
    return this.httpClient.delete<Especie>(this.apiUrl + "/" + id);//return obs

  }
  getById(id:string): Observable<Especie> {
    return this.httpClient.get<Especie>(this.apiUrl + "/" + id);//return obs
   
}}
