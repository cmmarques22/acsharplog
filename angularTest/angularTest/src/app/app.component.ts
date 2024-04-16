import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title: string = 'angularTest';
  Batata: string = 'Batatas';
  Cenoura: string = 'Cenouras';
  vegetables = [
    { name: 'Potatoes', price: 1 },
    { name: 'Carrots', price: 10 },
    { name: 'Cucumber', price: 100 },
  ];
  moduleName: string = 'Students';
  studentName: string = 'Peter';
  myCSSClass: string = 'red';
  applyCSSClass: boolean = true;
  fontCSSColor: string = '#d966ff';

  setStudentName(studentName: string) {
    this.studentName = studentName;
  }

  showData($event: any) {
    console.log('button was clicked');
    if ($event) {
      console.log($event.target);
      console.log($event.target.innerHTML);
      $event.target.innerHTML = 'clicked';
    }
  }

  isLogIn: boolean = true;
}
