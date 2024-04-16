import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title: string = 'angularTest';
  Batata: string = 'Batatas';
  Cenoura: string = 'Cenouras';
  
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
  Drogas = [
    { name: 'Crack', price: 1 },
    { name: 'LSD', price: 10 },
    { name: 'Cocaina', price: 100 },
  ];
  logInName: string = "admin";
  Legumes = ["cenouras", "batatas", "tomate é fruto??"];

  presentDate = new Date();
  price: number = 10.00;
  discount:number = 0.2599;

  onClickSubmit(result:any) {
    console.log("you have enetered : " + result.username);
  
  }

  formData = {
    name: '',
    email: ''
  };

  onSubmit() {
    console.log(this.formData)
  }

  



}
