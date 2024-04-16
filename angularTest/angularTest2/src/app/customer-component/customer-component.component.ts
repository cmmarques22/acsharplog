import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-customer-component',
  templateUrl: './customer-component.component.html',
  styleUrl: './customer-component.component.css'
})


export class CustomerComponentComponent implements OnInit {
id:number = 0;

constructor(private route:ActivatedRoute) {
  this.id =0;
}

  ngOnInit(): void {
    const idString = this.route.snapshot.paramMap.get('id');
    this.id = idString !== null ? parseInt(idString) :0;
  }

}  

