import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SmartInfoCardComponent } from './smart-info-card.component';

describe('SmartInfoCardComponent', () => {
  let component: SmartInfoCardComponent;
  let fixture: ComponentFixture<SmartInfoCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SmartInfoCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SmartInfoCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
