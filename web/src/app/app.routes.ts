import { NgModule } from '@angular/core';
import { RouterModule ,Routes } from '@angular/router';
import { FuncionariosComponent } from './pages/funcionarios.component/funcionarios.component';
import { IntroComponent } from './pages/intro.component/intro.component';

export const routes: Routes = [
    {
        path: '',
        component: IntroComponent,
        
    },
    {
        path: 'funcionarios',
        component: FuncionariosComponent
    }
];
