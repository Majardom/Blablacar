import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InputDialogFieldComponent } from './input-dialog-field.component';

describe('InputDialogFieldComponent', () => {
  let component: InputDialogFieldComponent;
  let fixture: ComponentFixture<InputDialogFieldComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InputDialogFieldComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InputDialogFieldComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
