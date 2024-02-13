import { Component, OnInit } from '@angular/core';
import { TipoOcorrenciaService } from '../tipo-ocorrencia.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-delete-tipo-ocorrencia',
  templateUrl: './delete-tipo-ocorrencia.component.html',
  styleUrl: './delete-tipo-ocorrencia.component.css'
})
// ...

export class DeleteTipoOcorrenciaComponent implements OnInit {
  id: number = 0;

  constructor(
    private service: TipoOcorrenciaService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    const idString = this.route.snapshot.paramMap.get('idTipoOcorrencia');
    this.id = idString !== null ? parseInt(idString) : 0;
    console.log(this.id);
    // Automatically fetch details on component initialization (if needed)
  }

  deleteTipoOcorrencia(): void {
    if (this.id !== undefined) {
      this.service.delete(this.id.toString()).subscribe(
        (response: any) => {
          console.log('Sucesso:', response);
          alert("Success deleting");
          // Redirect to the list page or perform any other navigation
          this.router.navigate(['/list-tipo-ocorrencias']);
        },
        (error: any) => {
          console.error('Erro:', error);
        }
      );
    }
  }
}
