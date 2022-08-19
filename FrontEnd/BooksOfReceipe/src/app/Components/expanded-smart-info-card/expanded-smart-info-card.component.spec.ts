import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExpandedSmartInfoCardComponent } from './expanded-smart-info-card.component';

describe('ExpandedSmartInfoCardComponent', () => {
  let component: ExpandedSmartInfoCardComponent;
  let fixture: ComponentFixture<ExpandedSmartInfoCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExpandedSmartInfoCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExpandedSmartInfoCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
