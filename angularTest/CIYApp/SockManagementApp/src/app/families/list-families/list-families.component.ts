import { Component, OnInit } from '@angular/core';
import { Family } from '../family';
import { FamilyService } from '../family.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-families',
  templateUrl: './list-families.component.html',
  styleUrl: './list-families.component.css'
})
export class ListFamiliesComponent implements OnInit {

  familiesList: Family[] = [];
  family?: Family = undefined;
  constructor(private service: FamilyService) {
  }
  ngOnInit(): void {
   this.service.getAll().then((data: Observable<Family[]>) => {
    //o then recebe um retorn subscribe para tirar a lista de familas por causa da promise
    // so é preciso fazer o subscribe
    data.subscribe(list => {
      console.log(list);
      this.familiesList = list;
    });
   }).catch(error => {
    console.log(error);
   });
  }
}
