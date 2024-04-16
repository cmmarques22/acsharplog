import { Component, OnInit } from '@angular/core';
import { TipoOcorrenciaService } from '../tipo-ocorrencia.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-delete-tipo-ocorrencia',
  templateUrl: './delete-tipo-ocorrencia.component.html',
  styleUrls: ['./delete-tipo-ocorrencia.component.css']
})

export class DeleteTipoOcorrenciaComponent implements OnInit {
  id: number = 0;

  constructor(
    private service: TipoOcorrenciaService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    const idString = this.route.snapshot.paramMap.get('id');
    this.id = idString !== null ? parseInt(idString) : 0;
    console.log(this.id);
  }

  deleteTipoOcorrencia(): void {
    if (this.id !== undefined) {
      this.service.delete(this.id.toString()).subscribe(
        (response: any) => {
          console.log('Success:', response);
          alert("Success deleting");
          this.router.navigate(['/tiposOcorrencias']);
        },
        (error: any) => {
          console.error('Error status:', error.status);
          console.error('Error message:', error.message);
        }
      );
    }
  }
  
}
