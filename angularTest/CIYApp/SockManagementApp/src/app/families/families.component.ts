import { Component } from '@angular/core';

@Component({
  selector: 'app-families',
  templateUrl: './families.component.html',
  styleUrl: './families.component.css'
})
export class FamiliesComponent {

  currentComponent: string = 'none';

  openComponent(hyperLink: any) {


    if(hyperLink) {
      if(hyperLink.id == "list") {
        this.currentComponent = "list-families";
      }
      else if(hyperLink.id == "create") {
        this.currentComponent = "create-family";
      }
      else if(hyperLink.id == "update") {
        this.currentComponent = "update-family";
      }
      else if(hyperLink.id == "read") {
        this.currentComponent = "read-family";
      }
      else if(hyperLink.id == "delete") {
        this.currentComponent = "delete-family";
      }
      else {
        this.currentComponent = '';
      }
        }}};