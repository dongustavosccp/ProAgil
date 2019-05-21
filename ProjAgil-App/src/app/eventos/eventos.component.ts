import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {
  eventos: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getEventos();
  }

  getEventos() {
    this.http.get('https://localhost:7898/api/values').subscribe(response => {
      console.log(response);
      this.eventos = response;
    },
    error => {
        console.log(error);
    });
  }
}
