import { Component } from '@angular/core';

@Component({
  selector: 'app-mostrar-ocultar',
  templateUrl: './mostrar-ocultar.component.html',
  styleUrl: './mostrar-ocultar.component.css'
})
export class MostrarOcultarComponent {

  mostrarConteudo: boolean = false;

  alteraConteudo() {
    this.mostrarConteudo = !this.mostrarConteudo;
  }
}
