import { Component } from '@angular/core';

@Component({
  selector: 'app-tipo-ocorrencias',
  templateUrl: './tipo-ocorrencias.component.html',
  styleUrl: './tipo-ocorrencias.component.css'
})
export class TipoOcorrenciasComponent {

  currentComponent: string = 'none';

  openComponent(hyperLink: any) {


    if(hyperLink) {
      if(hyperLink.id == "list") {
        this.currentComponent = "list-tipo-ocorrencias";
      }
      else if(hyperLink.id == "create") {
        this.currentComponent = "create-tipo-ocorrencia";
      }
      else if(hyperLink.id == "update") {
        this.currentComponent = "update-tipo-ocorrencia";
      }
      else if(hyperLink.id == "read") {
        this.currentComponent = "read-tipo-ocorrencia";
      }
      else if(hyperLink.id == "delete") {
        this.currentComponent = "delete-tipo-ocorrencia";
      }
      else {
        this.currentComponent = '';
      }
        }}



}
