import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EspecieService } from '../especie.service';
import { Especie } from '../especie';

@Component({
  selector: 'app-create-especie',
  templateUrl: './create-especie.component.html',
  styleUrls: ['./create-especie.component.css']
})
export class CreateEspecieComponent {
  especie: Especie;
  createForm: FormGroup;

  constructor(private service: EspecieService, private formBuilder: FormBuilder) {
    this.createForm = this.formBuilder.group({
      Classe: ['', [Validators.required]],
      Especie1: ['', [Validators.required]],
    });
  
    this.especie = {
      IdEspecie: null,
      Classe: '',
      Especie1: ''
    };
  }

  async create() {
    const payload = {
      Classe: this.especie.Classe,
      Especie1: this.especie.Especie1,
    };

    console.log(payload);

    (await this.service.create(payload)).subscribe(
      data => {
        alert("Success creating especie");
        console.log(data, "1");
        this.createForm.reset();
        this.especie = {
          IdEspecie: null,
          Classe: '',
          Especie1: ''
        };
      },
      error => {
        alert('Error creating especie');
        console.log(error, "2");
      }
    );
  }
}
