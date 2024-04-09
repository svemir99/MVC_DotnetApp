import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AttendantsListComponent } from './attendants-list.component';

describe('AttendantsListComponent', () => {
  let component: AttendantsListComponent;
  let fixture: ComponentFixture<AttendantsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AttendantsListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AttendantsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
