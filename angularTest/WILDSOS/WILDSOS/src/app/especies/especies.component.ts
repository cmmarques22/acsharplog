import { Component } from '@angular/core';

@Component({
  selector: 'app-especies',
  templateUrl: './especies.component.html',
  styleUrl: './especies.component.css'
})
export class EspeciesComponent {

  currentComponent: string = 'none';

  openComponent(hyperLink: any) {


    if(hyperLink) {
      if(hyperLink.id == "list") {
        this.currentComponent = "list-especies";
      }
      else if(hyperLink.id == "create") {
        this.currentComponent = "create-especie";
      }
      else if(hyperLink.id == "update") {
        this.currentComponent = "update-especie";
      }
      else if(hyperLink.id == "read") {
        this.currentComponent = "read-especie";
      }
      else if(hyperLink.id == "delete") {
        this.currentComponent = "delete-especie";
      }
      else {
        this.currentComponent = '';
      }
        }}};