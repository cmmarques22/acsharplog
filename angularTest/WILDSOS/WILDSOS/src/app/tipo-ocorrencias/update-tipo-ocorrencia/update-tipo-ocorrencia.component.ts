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
  // novoTPO: { descricao: string; };
  // tipoOcorrencia: TipoOcorrencia;
  id: any;
  // tipoOcorrencia: number;
  // constructor(private route: ActivatedRoute,private service: TipoOcorrenciaService) {}
    constructor(private service: TipoOcorrenciaService, private route: ActivatedRoute,private router: Router ) {
      this.novoTO = {descricao: ''};
    };
  
  ngOnInit(): void {
    const idString = this.route.snapshot.paramMap.get('id');
    console.log(idString);
    this.id = idString !== null ? parseInt(idString) : 0;
    this.getById(); 
    // Automatically fetch details on component initialization
  }

  getById() {
    try {
      if (this.id !== undefined) {
        // Assuming you have a service method named 'getById'
        this.service.getById(this.id).subscribe((data: TipoOcorrencia) => {
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
        this.router.navigate(['/list-tipo-ocorrencias']);
      },
      (error: any) => {
        console.error('Erro:', error);
      }
    );
  }
}
}
  // //   novoTPO: any = {}; 

// //   constructor(private service: TipoOcorrenciaService) { }

// //   atualizarCodigoPostal(): void {
// //     if (!this.novoTPO || !this.novoTPO.TipoOcorrencia) {
// //       return;
// //     }
// //     this.service.update(this.novoTPO.id, this.novoTPO)
// //       .subscribe({
// //         next: (response: any) => {
// //           console.log('sucesso:', response);
// //         },
// //         error: (error: any) => {
// //           console.error('Erro:', error);
// //         }
// //       });
// //   }
// tipoOcorrencia: number = 0;
//   service: any;
// constructor(private route: ActivatedRoute) {
//   this.tipoOcorrencia.IdTipoOcorrencia;

//   };
//   ngOnInit(): void {
//     const idString = this.route.snapshot.paramMap.get('id');
//     this.id = idString !== null? parseInt(idString): 0;
//   }

//   getById() {
//     try {
//       if (this.tipoOcorrencia.IdTipoOcorrencia !== undefined) {
//         this.service.getById(this.tipoOcorrencia.idCodigoPostal).subscribe((data: number) => {
//           this.tipoOcorrencia = data;
//         });
//       }


//     } catch (error) {
//       alert(error);
//     }

// }
 
// }

// import { Component, ɵprovideZonelessChangeDetection } from '@angular/core';
// import { TipoOcorrenciaService } from '../tipo-ocorrencia.service';
// import { TipoOcorrencia } from '../tipo-ocorrencia';
// import { ActivatedRoute } from '@angular/router';

// @Component({
//   selector: 'app-update-tipo-ocorrencia',
//   templateUrl: './update-tipo-ocorrencia.component.html',
//   styleUrl: './update-tipo-ocorrencia.component.css'
// })
// export class UpdateTipoOcorrenciaComponent {

//   novoTPO: TipoOcorrencia;
//   idTipoOcorrencia: any;

//   constructor(private service: TipoOcorrenciaService, private route: ActivatedRoute) {
//     this.novoTPO = {
//       descricao: ''
//     };
//     this.route.params.subscribe(params => {
//       const idTipoOcorrencia = params['idTipoOcorrencia'];
//       if (idTipoOcorrencia) {
//         this.loadTipoOcorrencia(idTipoOcorrencia);
//       }
//     });
//   }
//   loadTipoOcorrencia(idTipoOcorrencia: string): void {
//     this.service.getById(idTipoOcorrencia).subscribe(
//       (data: TipoOcorrencia) => {
//         this.novoTPO = data;
//       },
//       (error: any) => {
//         console.error('Error loading tipoOcorrencia:', error);
//       }
//     );
//   }

//   atualizarTPO(): void {
//     if (this.novoTPO.idTipoOcorrencia !== undefined) {
//       this.service.update(this.novoTPO.idTipoOcorrencia, this.novoTPO)
//         .subscribe({
//           next: (response: any) => {
//             console.log('Sucesso:', response);
//           },
//           error: (error: any) => {
//             console.error('Erro:', error);
//           }
//         });
//     }
//   }

    
 

//   getById() {
//     try {
//       if (this.idTipoOcorrencia.idCodigoPostal !== undefined) {
//         this.service.getById(this.idTipoOcorrencia.idCodigoPostal).subscribe(data => {
//           this.idTipoOcorrencia = data;
//         });
//       }


//     } catch (error) {
//       alert(error);
//     }
//   }


// }
