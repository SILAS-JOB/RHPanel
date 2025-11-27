import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from './funcionario.model';



@Injectable({providedIn: 'root'})
export class FuncionariosService {
  private http = inject(HttpClient);

  private apiUrl = 'http://localhost:5272/api/v1/user';


  getItems(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.apiUrl);
  }
 
  createItem(item: Employee) : Observable<Employee> {
    return this.http.post<Employee>(this.apiUrl, item)
  } 

}
