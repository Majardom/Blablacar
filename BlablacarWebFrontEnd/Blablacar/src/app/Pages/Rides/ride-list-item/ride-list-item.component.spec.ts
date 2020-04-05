import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RideListItemComponent } from './ride-list-item.component';

describe('RideListItemComponent', () => {
  let component: RideListItemComponent;
  let fixture: ComponentFixture<RideListItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RideListItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RideListItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
