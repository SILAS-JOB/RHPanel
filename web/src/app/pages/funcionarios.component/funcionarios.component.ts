import { Component, NgZone, OnInit } from '@angular/core';
import { FuncionariosService } from '../../services/funcionarios.service';
import { CommonModule } from '@angular/common';
import { Employee } from '../../services/funcionario.model';




@Component({
  selector: 'app-funcionarios',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './funcionarios.component.html', 
  styleUrls: ['./funcionarios.component.scss'],
})
export class FuncionariosComponent implements OnInit {
  employees: Employee[] = [];
  loading = true;
  error: string | null = null;

  constructor(
    private funcionariosService: FuncionariosService,
    private zone: NgZone  // Injeta o NgZone
  ) {}

  ngOnInit(): void {
    this.funcionariosService.getItems().subscribe({
      next: (data: Employee[]) => {
        // Roda a atualização das variáveis dentro da zona do Angular
        this.zone.run(() => {
          this.employees = data;
          this.loading = false;
        });
      },
      error: (err) => {
        // Roda a atualização do erro dentro da zona também
        this.zone.run(() => {
          this.error = "Erro ao carregar empregados";
          this.loading = false;
          console.error('Erro carregando no fetch da api', err);
        });
      }
    });
  }
}