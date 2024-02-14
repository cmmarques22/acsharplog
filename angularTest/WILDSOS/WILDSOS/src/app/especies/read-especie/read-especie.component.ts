import { Component, OnInit } from '@angular/core';
import { EspecieService } from '../especie.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Especie } from '../especie';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-read-especie',
  templateUrl: './read-especie.component.html',
  styleUrls: ['./read-especie.component.css']
})
export class ReadEspecieComponent implements OnInit{

  id: any;
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
          this.especie = data;
        });

        
      }
    } catch (error) {
      alert(error);
    }
  }

  showDetail() {
    this.showEspecieDetails = !this.showEspecieDetails;
  }
  
  goBackEspecie() {
    // Navigate back to the main page
    this.router.navigate(['/especies']);
}
searchNewId() {
  this.router.navigate(['/read-especie']);

  }
}
