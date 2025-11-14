import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FuncionariosPartialComponent } from './funcionarios.partial.component';

describe('FuncionariosPartialComponent', () => {
  let component: FuncionariosPartialComponent;
  let fixture: ComponentFixture<FuncionariosPartialComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FuncionariosPartialComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FuncionariosPartialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
