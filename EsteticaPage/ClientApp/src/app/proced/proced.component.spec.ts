import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProcedComponent } from './proced.component';

describe('ProcedComponent', () => {
  let component: ProcedComponent;
  let fixture: ComponentFixture<ProcedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProcedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProcedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
