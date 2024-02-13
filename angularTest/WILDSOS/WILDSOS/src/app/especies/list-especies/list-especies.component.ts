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
  especie?: Especie = undefined;
  constructor(private service: EspecieService) {
  }
  
  ngOnInit() {
    this.service.getAll().then((data: Observable<Especie[]>)=> {
      data.subscribe(list => {
        console.log(list); // Log the received data
        this.especiesList = list;
      });
    });
  }

  
}


// ngOnInit(): void {
  //  this.service.getAll().then((data: Observable<Especie[]>) => {
  //   //o then recebe um retorn subscribe para tirar a lista de especies por causa da promise
  //   // so é preciso fazer o subscribe
  //   data.subscribe(list => {
  //     console.log(list);
  //     this.especiesList = list;
  //   });
  //  }).catch(error => {
  //   console.log(error);
  //  });
  // }
