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

  apiUrl: string = "";

  constructor(private httpClient: HttpClient) {
    this.apiUrl = environment.apiUrl + "Especies";
   };



   async getAll(): Promise<Observable<Especie[]>> {
  const data = await this.httpClient.get<Especie[]>(this.apiUrl);
  console.log(data); // Log the received data
  return   await this.httpClient.get<Especie[]>(this.apiUrl);;
}

async create(especieBody: any): Promise<Observable<Especie>> {
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  return await this.httpClient.post<Especie>(this.apiUrl, especieBody, httpOptions);
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
  getEspecieById(id:string): Observable<Especie> {
    return this.httpClient.get<Especie>(this.apiUrl + "/" + id);//return obs
  }
  getCountEspecie(): Observable<number> {
      return this.httpClient.get<number>(this.apiUrl + "/" + "CountEspecies");

}
}
