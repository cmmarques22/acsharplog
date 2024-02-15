import { Component, OnInit } from '@angular/core';
import { EspecieService } from './especie.service';
import { Especie } from './especie';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-especies',
  templateUrl: './especies.component.html',
  styleUrl: './especies.component.css'
})
export class EspeciesComponent implements OnInit{

  currentEspecieComponent: string = 'none';


  //logica para abrir o create
  openEspecieComponent(hyperLink: any) {
  
  
    if(hyperLink) {
    
       if(hyperLink.id == "create") {
        this.currentEspecieComponent = "create-especie";
      }
     
      else {
        this.currentEspecieComponent = '';
       }
        }}
    
    especiesList: Especie[] = [];
    especie?: Especie = undefined;
    counter: number | undefined;
    changeView: boolean = true;
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
        }).catch((error: any) => {
         console.log(error);
        });

        //mais facil criar metodo fora e chamar aqui  
        this.service.getCountEspecie().subscribe( (counterEspecies: number) => {
          console.log(counterEspecies);
          this.counter = counterEspecies;
        });
       }
       
       
       getImageSource(especie1: string): string {
        return '/assets/images/' + especie1 + '.png';  }

        toggleView() {
          this.changeView = !this.changeView;
          }

};