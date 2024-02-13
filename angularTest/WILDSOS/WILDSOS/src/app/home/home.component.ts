import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  currentComponent: string = 'none';

  openComponent(hyperLink: any) {
    if (hyperLink) {
      if (hyperLink.id === "list") {
        this.currentComponent = "list-tipo-ocorrencias";
      } else {
        this.currentComponent = '';
      }
    }
  }
}
