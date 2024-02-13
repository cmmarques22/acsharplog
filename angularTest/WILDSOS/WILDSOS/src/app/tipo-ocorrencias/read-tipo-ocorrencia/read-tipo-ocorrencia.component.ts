import { Component } from '@angular/core';
import { TipoOcorrenciaService } from '../tipo-ocorrencia.service';
import { TipoOcorrencia } from '../tipo-ocorrencia';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-read-tipo-ocorrencia',
  templateUrl: './read-tipo-ocorrencia.component.html',
  styleUrls: ['./read-tipo-ocorrencia.component.css']
})
export class ReadTipoOcorrenciaComponent {

  idTipoOcorrencia: number | undefined;
  tipoOcorrencia: TipoOcorrencia;
  showDetails: boolean = false;

  constructor(private service: TipoOcorrenciaService, private route: ActivatedRoute, private router: Router) {
    this.tipoOcorrencia = {
      idTipoOcorrencia: 0,
      descricao: ''
    };
  }

  getById() {
    try {
      if (this.idTipoOcorrencia !== undefined) {
        // Convert idTipoOcorrencia to string
        const idString = this.idTipoOcorrencia.toString();
        
        // Assuming you have a service method named 'getById'
        this.service.getById(idString).subscribe((data: TipoOcorrencia) => {
          console.log(data);
          this.tipoOcorrencia = data;
          this.showDetails = true; // Show details after successful retrieval
        });
      }
    } catch (error) {
      alert(error);
    }
  }
  
  goBack() {
    // Navigate back to the main page
    this.router.navigate(['/list-tipo-ocorrencias']);
}
searchNewId() {
  this.router.navigate(['/read-tipo-ocorrencia']);

  }
}