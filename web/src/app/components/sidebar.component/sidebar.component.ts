import { Component } from '@angular/core';
import { RouterLinkWithHref, RouterLink } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  imports: [RouterLink],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.scss',
  providers: [
    RouterLinkWithHref
  ]
})
export class SidebarComponent {

}


