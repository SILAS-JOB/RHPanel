import { Component } from '@angular/core';
import { routes } from '../../app.routes';
import { RouterLinkActive, RouterLinkWithHref, RouterLink } from '@angular/router';

@Component({
  selector: 'app-navbar',
  imports: [RouterLink],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss',
  providers: [
    RouterLinkWithHref
  ]
})
export class NavbarComponent {

}

