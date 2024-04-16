import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { Family } from './family';

@Injectable({
  providedIn: 'root'
})
export class FamilyService {
  [x: string]: any;
  apiUrl: string = "";

  constructor(private httpClient: HttpClient) {
    this.apiUrl = environment.apiUrl + "Families";
   };

  //  apiUrl: string = environment.apiUrl + 'Families';  // Adjust the concatenation here

  // constructor(private httpClient: HttpClient) {}

   async getAll(): Promise<Observable<Family[]>> {
    return await this.httpClient.get<Family[]>(this.apiUrl);
   };

   async create(familyBody: any): Promise<Observable<Family>> {
    console.log(familyBody);

    const httpOptions = {
      headers: new HttpHeaders( {
        'Content-Type': 'application/json'
        //adicione cabeçalhos
      })
    }; return await this.httpClient.post<Family>(this.apiUrl, familyBody, httpOptions);
   }

   update(id: string, body: any): Observable<Family> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
        //adicione outros cabelçalhos

      })
    };
    return this.httpClient.put<Family>(this.apiUrl + "/" + id, body, httpOptions);//return an obser

  }

  delete(id:string): Observable<Family> {
    return this.httpClient.delete<Family>(this.apiUrl + "/" + id);//return obs

  }
  getById(id:string): Observable<Family> {
    return this.httpClient.get<Family>(this.apiUrl + "/" + id);//return obs
   
}}
