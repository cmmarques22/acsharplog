import { Component, OnInit } from '@angular/core';
import { TipoOcorrenciaService } from '../tipo-ocorrencia.service';
import { TipoOcorrencia } from '../tipo-ocorrencia';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-read-tipo-ocorrencia',
  templateUrl: './read-tipo-ocorrencia.component.html',
  styleUrls: ['./read-tipo-ocorrencia.component.css']
})
export class ReadTipoOcorrenciaComponent implements OnInit{

  id: any;
  idTipoOcorrencia: number | undefined;
  tipoOcorrencia: TipoOcorrencia;
  showTODetails: boolean = false;

  constructor(private service: TipoOcorrenciaService, private route: ActivatedRoute, private router: Router) {
    this.tipoOcorrencia = {
      idTipoOcorrencia: 0,
      descricao: ''
    };
  }
  ngOnInit(): void {
    const idStringTO= this.route.snapshot.paramMap.get('id');
    console.log(idStringTO);
    this.id = idStringTO !== null ? parseInt(idStringTO) : 0;
    this.getTOById(); 
    // Automatically fetch details on component initialization
  }

  getTOById() {
    try {
      if (this.id !== undefined) {
        // Assuming you have a service method named 'getById'
        this.service.getTOById(this.id).subscribe((data: TipoOcorrencia) => {
          console.log(data);
          this.tipoOcorrencia = data;
        });

        
      }
    } catch (error) {
      alert(error);
    }
  }

  showDetailTO() {
    this.showTODetails = !this.showTODetails;
  }
  
  goBack() {
    // Navigate back to the main page
    this.router.navigate(['/tiposOcorrencias']);
}
searchNewId() {
  this.router.navigate(['/read-tipo-ocorrencia']);

  }
}
