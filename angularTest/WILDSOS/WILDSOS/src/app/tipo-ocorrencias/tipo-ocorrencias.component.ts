import { Component,OnInit  } from '@angular/core';
import { TipoOcorrenciaService } from './tipo-ocorrencia.service';
import { TipoOcorrencia } from './tipo-ocorrencia';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-tipo-ocorrencias',
  templateUrl: './tipo-ocorrencias.component.html',
  styleUrl: './tipo-ocorrencias.component.css'
})
export class TipoOcorrenciasComponent {


currentComponent: string = 'none';

openComponent(hyperLink: any) {


  if(hyperLink) {
  
     if(hyperLink.id == "create") {
      this.currentComponent = "create-tipo-ocorrencia";
    }
   
    else {
      this.currentComponent = '';
     }
      }}
  

  counter: number | undefined;
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
      }).catch((error: any) => {
       console.log(error);
      });
    
     }
      


     getImageSource(descricao: string): string {
      // Assuming your image files are named like 'Desastre Natural.jpg', 'Derrocada.jpg', etc.
      return '/assets/images/' + descricao + '.png';  }
  

}
