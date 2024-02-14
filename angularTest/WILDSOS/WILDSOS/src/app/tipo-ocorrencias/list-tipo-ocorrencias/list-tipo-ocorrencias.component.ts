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
  // tipoOcorrencia?: TipoOcorrencia = undefined;
  tipoOcorrencia: any = {
    idTipoOcorrencia: 1,
    descricao: 'Desastre Natural' // Set the default value or get it from your data source
  };

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
  getImageSource(descricao: string): string {
    // Assuming your image files are named like 'Desastre Natural.jpg', 'Derrocada.jpg', etc.
    return '/assets/images/' + descricao + '.png';  }

}
