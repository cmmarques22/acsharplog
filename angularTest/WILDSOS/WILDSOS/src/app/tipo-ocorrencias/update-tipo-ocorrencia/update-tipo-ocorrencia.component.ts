import { Component, OnInit } from '@angular/core';
import { TipoOcorrenciaService  } from '../tipo-ocorrencia.service';
import { ActivatedRoute, Router } from '@angular/router';
import { TipoOcorrencia } from '../tipo-ocorrencia';

@Component({
  selector: 'app-update-tipo-ocorrencia',
  templateUrl: './update-tipo-ocorrencia.component.html',
  styleUrl: './update-tipo-ocorrencia.component.css'
})
export class UpdateTipoOcorrenciaComponent  implements OnInit{


novoTO: TipoOcorrencia;
  id: any;
    constructor(private service: TipoOcorrenciaService, private route: ActivatedRoute,private router: Router ) {
      this.novoTO = {descricao: ''};
    };
  
  ngOnInit(): void {
    const idString = this.route.snapshot.paramMap.get('id');
    console.log(idString);
    this.id = idString !== null ? parseInt(idString) : 0;
    this.getTOById(); 
    // Automatically fetch details on component initialization
  }

  getTOById() {
    try {
      if (this.id !== undefined) {
        // Assuming you have a service method named 'getById'
        this.service.getTOById(this.id).subscribe((data: TipoOcorrencia) => {
          console.log(data);
          this.novoTO = data;
        });
      }
    } catch (error) {
      alert(error);
    }
  }

atualizarTPO(): void {
  if (this.id !== undefined) {
    this.service.update(this.id, this.novoTO).subscribe(
      (response: any) => {
        
        console.log('sucesso:', response);
        alert("Success updating");
        this.router.navigate(['/tiposOcorrencias']);
      },
      (error: any) => {
        console.error('Erro:', error);
      }
    );
  }
}
}
