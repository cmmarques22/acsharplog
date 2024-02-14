import { Component, OnInit } from '@angular/core';
import { Especie } from '../especie';
import { EspecieService } from '../especie.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-especies',
  templateUrl: './list-especies.component.html',
  styleUrl: './list-especies.component.css'
})
export class ListEspeciesComponent implements OnInit {

  especiesList: Especie[] = [];
  especie: any = {
    idEspecie: 1,
    especie1: 'Ave',
    classe: 'Tartaruga' 
  };
  constructor(private service: EspecieService) {
  }
  
  ngOnInit(): void {
    this.service.getAll().then((data: Observable<Especie[]>) => {
     //o then recebe um retorn subscribe para tirar a lista de familas por causa da promise
     // so é preciso fazer o subscribe
     data.subscribe(list => {
       console.log(list);
       this.especiesList = list;
     });
    }).catch(error => {
     console.log(error);
    });
   }
   getImageSource(especie1: string): string {
     // Assuming your image files are named like 'Desastre Natural.jpg', 'Derrocada.jpg', etc.
     return '/assets/images/' + especie1 + '.png';  }
 
 }



