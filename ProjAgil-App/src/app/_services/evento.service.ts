import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IEvento } from '../_models/IEvento';

@Injectable({
  providedIn: 'root'
})
export class EventoService {
  baseURL = 'https://localhost:7898/api/Evento';

  constructor(private http: HttpClient) {}

  getAllEventos(): Observable<IEvento[]> {
    return this.http.get<IEvento[]>(this.baseURL);
  }

  getEventoByTema(tema: string): Observable<IEvento[]> {
    return this.http.get<IEvento[]>(`${this.baseURL}/${tema}`);
  }

  getEventoById(id: number): Observable<IEvento> {
    return this.http.get<IEvento>(`${this.baseURL}/${id}`);
  }
}
