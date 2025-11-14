import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from "./components/navbar.component/navbar.component";
import { SidebarComponent } from "./components/sidebar.component/sidebar.component";
import { FooterComponent } from "./components/footer.component/footer.component";
import { FuncionariosComponent } from "./pages/funcionarios.component/funcionarios.component";
import { IntroComponent } from "./pages/intro.component/intro.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NavbarComponent, SidebarComponent, FooterComponent, FuncionariosComponent, IntroComponent],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('RHPanel');
}
