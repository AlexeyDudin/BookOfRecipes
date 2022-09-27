import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IngridientComponent } from './ingridient.component';

describe('IngridientComponent', () => {
  let component: IngridientComponent;
  let fixture: ComponentFixture<IngridientComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IngridientComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IngridientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
