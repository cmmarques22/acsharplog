import { Component } from '@angular/core';
import { EspecieService } from '../especie.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Especie } from '../especie';

@Component({
  selector: 'app-read-especie',
  templateUrl: './read-especie.component.html',
  styleUrls: ['./read-especie.component.css']
})
export class ReadEspecieComponent {

  idEspecie: number | undefined;
  especie: Especie;
  showEspecieDetails: boolean = false;

  constructor(private service: EspecieService, private route: ActivatedRoute, private router: Router) {
    this.especie = {
      idEspecie: 0,
      classe: '',
      especie1: ''
    };
  }

  getEspecieById() {
    try {
      if (this.idEspecie !== undefined) {
        // Convert idTipoOcorrencia to string
        const idString = this.idEspecie.toString();
        
        // Assuming you have a service method named 'getById'
        this.service.getEspecieById(idString).subscribe((data: Especie) => {
          console.log(data);
          this.especie = data;
          this.showEspecieDetails = true; // Show details after successful retrieval
        });
      }
    } catch (error) {
      alert(error);
    }
  }
  
  goBackEspecie() {
    // Navigate back to the main page
    this.router.navigate(['/especies']);
}
searchNewId() {
  this.router.navigate(['/read-especie']);

  }
}
