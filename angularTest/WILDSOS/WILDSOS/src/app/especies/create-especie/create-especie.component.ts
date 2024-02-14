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
      idEspecie: ['', [Validators.required]],
      classe: ['', [Validators.required]],
      especie1: ['', [Validators.required]],
    });

    this.especie = {
      // idEspecie: null,
      classe: '',
      especie1: ''
    };
  }

  create() {
    console.log(this.especie);
    this.service.create(this.especie).then(data => {
      data.subscribe(data => {
        alert('Especie criada');
        console.log(data, '1');
        location.reload();
      });
    }).then(() => {
      this.createForm.reset();
      this.especie = {
        // IdTipoOcorrencia: '',
        classe: '',
        especie1: ''
      };
    }).catch(error => {
      alert('Erro ao criar especie');
      console.log(error, '2');
    });
  }
}

