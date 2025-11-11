import { Component, OnInit } from '@angular/core';
import { FuncionariosService } from '../../services/funcionarios.service';
import { CommonModule } from '@angular/common';



export interface Employee {
  id: number;
  name: string;
  admissionDate: Date;
  salary: number;
  isWorking: boolean;
  demissionDate?: Date;
  observation?: string;
}

@Component({
  selector: 'app-funcionarios',
  imports: [CommonModule],
  template: '<ul> @for(emp of employees; track emp.id){<li>{{emp.name}}</li>}</ul>',
  styleUrls: ['./funcionarios.component.scss'],
})
export class FuncionariosComponent implements OnInit {
  employees: Employee[] = [];
  loading = true;
  error: string | null = null;

  constructor(private funcionariosService : FuncionariosService ){}
  ngOnInit(): void {
    this.funcionariosService.getItems().subscribe({
      next: (data: Employee[]) => {
        this.employees = data;
        this.loading = false;
      },
      error: (err) => {
        this.error = "Erro ao carregar empregados"
        this.loading = false;
        console.error('Erro carregando no fetch da api')
      }
    });
    
  }
  renderizarFuncionarios(): void {
    this.funcionariosService.getItems().subscribe()
  }
}