import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TipoOcorrenciaService } from '../tipo-ocorrencia.service';
import { TipoOcorrencia } from '../tipo-ocorrencia';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-create-tipo-ocorrencia',
  templateUrl: './create-tipo-ocorrencia.component.html',
  styleUrl: './create-tipo-ocorrencia.component.css'
})
export class CreateTipoOcorrenciaComponent {
  tipoOcorrencia: TipoOcorrencia;
  createForm: FormGroup;
//passar component current
  constructor(private service: TipoOcorrenciaService, private formBuilder: FormBuilder) {
    this.createForm = this.formBuilder.group({
      idTipoOcorrencia: ['', [Validators.required]],
      descricao: ['', [Validators.required]],
    });
  
    this.tipoOcorrencia = {
      // idTipoOcorrencia: '',
      descricao: ''
    };
  }

  create(){
   console.log(this.tipoOcorrencia);
    this.service.create(this.tipoOcorrencia).then(data => {
      data.subscribe(data => {
        alert("Tipo de Ocorrencia criado");
        console.log(data, "1")
        location.reload();
      })
    }).then(() => {
      this.createForm.reset();
      this.tipoOcorrencia = {
        // IdTipoOcorrencia: '',
        descricao: ''
      }
    }).catch(error => {
      alert('erro criar tipo de ocorrencia');
      console.log(error, "2")

    });
  }



}
