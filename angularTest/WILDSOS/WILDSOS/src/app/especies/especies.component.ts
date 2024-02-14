import { Component, OnInit } from '@angular/core';
import { EspecieService } from './especie.service';
import { Especie } from './especie';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-especies',
  templateUrl: './especies.component.html',
  styleUrl: './especies.component.css'
})
export class EspeciesComponent {
  currentComponent: string = 'none';

  openComponent(hyperLink: any) {
  
  
    if(hyperLink) {
    
       if(hyperLink.id == "create") {
        this.currentComponent = "create-especie";
      }
     
      else {
        this.currentComponent = '';
       }
        }}
    
    especiesList: Especie[] = [];
    especie?: Especie = undefined;
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
       }
  
       getImageSource(especie1: string): string {
        // Assuming your image files are named like 'Ave.jpg', 'Réptil.jpg',and Mamífero
        return '/assets/images/' + especie1 + '.png';  }
  
        

//   currentComponent: string = 'none';

//   openComponent(hyperLink: any) {


//     if(hyperLink) {
//       if(hyperLink.id == "list") {
//         this.currentComponent = "list-especies";
//       }
//       else if(hyperLink.id == "create") {
//         this.currentComponent = "create-especie";
//       }
//       else if(hyperLink.id == "update") {
//         this.currentComponent = "update-especie";
//       }
//       else if(hyperLink.id == "read") {
//         this.currentComponent = "read-especie";
//       }
//       else if(hyperLink.id == "delete") {
//         this.currentComponent = "delete-especie";
//       }
//       else {
//         this.currentComponent = '';
//       }
//         }}




};