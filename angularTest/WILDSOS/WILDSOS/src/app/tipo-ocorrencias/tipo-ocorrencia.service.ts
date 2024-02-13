import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { TipoOcorrencia } from './tipo-ocorrencia';

@Injectable({
  providedIn: 'root'
})
export class TipoOcorrenciaService {
  // [x: string]: any;
  apiUrl: string = "";

  constructor(private httpClient: HttpClient) {
    this.apiUrl = environment.apiUrl + "TipoOcorrencias";
   };

  //  apiUrl: string = environment.apiUrl + 'Families';  // Adjust the concatenation here

  // constructor(private httpClient: HttpClient) {}

   async getAll(): Promise<Observable<TipoOcorrencia[]>> {
    return await this.httpClient.get<TipoOcorrencia[]>(this.apiUrl);
   };

   async create(tipoOcorrenciaBody: any): Promise<Observable<TipoOcorrencia>> {
    console.log(tipoOcorrenciaBody);

    const httpOptions = {
      headers: new HttpHeaders( {
        'Content-Type': 'application/json'
        //adicione cabeçalhos
      })
    }; return await this.httpClient.post<TipoOcorrencia>(this.apiUrl, tipoOcorrenciaBody, httpOptions);
   }

   update(id: number, body: any): Observable<TipoOcorrencia> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
        //adicione outros cabelçalhos

      })
    };
    return this.httpClient.put<TipoOcorrencia>(this.apiUrl + "/" + id, body, httpOptions);//return an obser

  }

  delete(id:string): Observable<TipoOcorrencia> {
    return this.httpClient.delete<TipoOcorrencia>(this.apiUrl + "/" + id);//return obs

  }
  getById(id:string): Observable<TipoOcorrencia> {
    return this.httpClient.get<TipoOcorrencia>(this.apiUrl + "/" + id);//return obs
   
}}
