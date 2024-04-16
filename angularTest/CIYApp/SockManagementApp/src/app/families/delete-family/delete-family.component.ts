// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-delete-family',
//   templateUrl: './delete-family.component.html',
//   styleUrl: './delete-family.component.css'
// })
// export class DeleteFamilyComponent {

// }
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FamilyService } from '../family.service';

@Component({
  selector: 'app-delete-family',
  templateUrl: './delete-family.component.html',
  styleUrls: ['./delete-family.component.css']
})
export class DeleteFamilyComponent {
  familyIdToDelete: string;

  constructor(private route: ActivatedRoute, private router: Router, private familyService: FamilyService) {
    this.familyIdToDelete = '';
  }

  deleteFamily() {
    this.familyService.delete(this.familyIdToDelete).subscribe(
      () => {
        alert('Family deleted successfully');
        this.router.navigate(['/families']);
      },
      error => {
        console.error(error);
        alert('Error deleting family');
      }
    );
  }
}
