import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UcLoginComponent } from './uclogin.component';

describe('LoginComponent', () => {
  let component: UcLoginComponent;
  let fixture: ComponentFixture<UcLoginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UcLoginComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UcLoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
