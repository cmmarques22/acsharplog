import { Component, OnInit } from '@angular/core';
import { TipoOcorrencia } from '../tipo-ocorrencia';
import { TipoOcorrenciaService } from '../tipo-ocorrencia.service';
import { Observable } from 'rxjs';
// import { HomeComponent } from './home/home.component';


@Component({
  selector: 'app-list-tipo-ocorrencias',
  templateUrl: './list-tipo-ocorrencias.component.html',
  styleUrl: './list-tipo-ocorrencias.component.css'
})
export class ListTipoOcorrenciasComponent implements OnInit {

  tipoOcorrenciaList: TipoOcorrencia[] = [];
  tipoOcorrencia?: TipoOcorrencia = undefined;
  constructor(private service: TipoOcorrenciaService) {
  }
  ngOnInit(): void {
   this.service.getAll().then((data: Observable<TipoOcorrencia[]>) => {
    //o then recebe um retorn subscribe para tirar a lista de familas por causa da promise
    // so é preciso fazer o subscribe
    data.subscribe(list => {
      console.log(list);
      this.tipoOcorrenciaList = list;
    });
   }).catch(error => {
    console.log(error);
   });
  }
}
