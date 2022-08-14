import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopReceipeComponent } from './top-receipe.component';

describe('TopReceipeComponent', () => {
  let component: TopReceipeComponent;
  let fixture: ComponentFixture<TopReceipeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopReceipeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TopReceipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
