import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SmartInfoComponent } from './smart-info.component';

describe('SmartInfoComponent', () => {
  let component: SmartInfoComponent;
  let fixture: ComponentFixture<SmartInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SmartInfoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SmartInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
