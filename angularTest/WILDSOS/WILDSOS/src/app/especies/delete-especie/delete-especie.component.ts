import { Component, OnInit } from '@angular/core';
import { EspecieService } from '../especie.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-delete-especie',
  templateUrl: './delete-especie.component.html',
  styleUrl: './delete-especie.component.css'
})
export class DeleteEspecieComponent implements OnInit {
  id: number = 0;

  constructor(
    private service: EspecieService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    const idString = this.route.snapshot.paramMap.get('idEspecie');
    this.id = idString !== null ? parseInt(idString) : 0;
    console.log(this.id);
    // Automatically fetch details on component initialization (if needed)
  }

  deleteEspecie(): void {
    if (this.id !== undefined) {
      this.service.delete(this.id.toString()).subscribe(
        (response: any) => {
          console.log('Sucesso:', response);
          alert("Eureka!");
          // Redirect to the list page or perform any other navigation
          this.router.navigate(['/especies']);
        },
        (error: any) => {
          console.error('Cum catano:', error);
        }
      );
    }
  }
}
