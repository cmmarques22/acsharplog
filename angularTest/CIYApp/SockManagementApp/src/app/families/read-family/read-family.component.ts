// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-read-family',
//   templateUrl: './read-family.component.html',
//   styleUrl: './read-family.component.css'
// })
// export class ReadFamilyComponent {

// }
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FamilyService } from '../family.service';
import { Family } from '../family';

@Component({
  selector: 'app-read-family',
  templateUrl: './read-family.component.html',
  styleUrls: ['./read-family.component.css']
})
export class ReadFamilyComponent implements OnInit {
  family?: Family;

  constructor(private route: ActivatedRoute, private familyService: FamilyService) { }

  ngOnInit() {
    const familyId = this.route.snapshot.params['id'];
    this.familyService.getById(familyId).subscribe(
      data => {
        this.family = data;
      },
      error => {
        console.error(error);
        alert('Error fetching family details');
      }
    );
  }
}
