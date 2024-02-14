import { Component,OnInit } from '@angular/core';
import { Especie } from '../especie';
import { ActivatedRoute, Router } from '@angular/router';
import { EspecieService  } from '../especie.service';


@Component({
  selector: 'app-update-especie',
  templateUrl: './update-especie.component.html',
  styleUrl: './update-especie.component.css'
})
export class UpdateEspecieComponent {


  novaEspecie: Especie;
  // novoTPO: { descricao: string; };
  // tipoOcorrencia: TipoOcorrencia;
  id: any;
  // tipoOcorrencia: number;
  // constructor(private route: ActivatedRoute,private service: TipoOcorrenciaService) {}
    constructor(private service: EspecieService, private route: ActivatedRoute,private router: Router ) {
      this.novaEspecie = {classe: '', especie1: ''};
    };
  
  ngOnInit(): void {
    const idStringEspecie = this.route.snapshot.paramMap.get('id');
    console.log(idStringEspecie);
    this.id = idStringEspecie !== null ? parseInt(idStringEspecie) : 0;
    this.getEspecieById(); 
    // Automatically fetch details on component initialization
  }

  getEspecieById() {
    try {
      if (this.id !== undefined) {
        // Assuming you have a service method named 'getById'
        this.service.getEspecieById(this.id).subscribe((data: Especie) => {
          console.log(data);
          this.novaEspecie = data;
        });
      }
    } catch (error) {
      alert(error);
    }
  }

atualizarEspecie(): void {
  if (this.id !== undefined) {
    this.service.update(this.id, this.novaEspecie).subscribe(
      (response: any) => {
        
        console.log('sucesso:', response);
        alert("Success updating");
        this.router.navigate(['/especies']);
      },
      (error: any) => {
        console.error('Erro:', error);
      }
    );
  }
}
}