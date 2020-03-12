import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProcedimentosComponent } from './procedimentos.component';

describe('ProcedimentosComponent', () => {
  let component: ProcedimentosComponent;
  let fixture: ComponentFixture<ProcedimentosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProcedimentosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProcedimentosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
