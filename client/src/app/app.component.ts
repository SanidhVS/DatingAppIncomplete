import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root', //App-route component
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating app';
  users: any;

  constructor(private http: HttpClient) {} //In order to make HTTP requests

  ngOnInit() {
    this.getUsers();
  }
   
    getUsers(){
      this.http.get("https://localhost:44313/api/Users").subscribe(response => {
        this.users = response;
      }, error => {
        console.log('Error')
      }) 
    }//This keyword is used to access properties of a class
  
}
