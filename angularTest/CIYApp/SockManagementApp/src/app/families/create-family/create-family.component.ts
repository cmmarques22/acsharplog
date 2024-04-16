import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FamilyService } from '../family.service';
import { Family } from '../family';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-create-family',
  templateUrl: './create-family.component.html',
  styleUrl: './create-family.component.css'
})
export class CreateFamilyComponent {
  family: Family;
  createForm: FormGroup;

  constructor(private service: FamilyService, private formBuilder: FormBuilder) {
    this.createForm = this.formBuilder.group({
      familyId: ['', [Validators.required]],
      familyName: ['', [Validators.required]],
    });
  
    this.family = {
      familyId: '',
      familyName: ''
    };
  }

  create(){
   console.log(this.family);
    this.service.create(this.family).then(data => {
      data.subscribe(data => {
        alert("sucesso criar familia");
        console.log(data, "1")
      })
    }).then(() => {
      this.createForm.reset();
      this.family = {
        familyId: '',
        familyName: ''
      }
    }).catch(error => {
      alert('erro criar familia');
      console.log(error, "2")

    });
  }



}
