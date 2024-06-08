import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavcontrolComponent } from './navcontrol.component';

describe('NavcontrolComponent', () => {
  let component: NavcontrolComponent;
  let fixture: ComponentFixture<NavcontrolComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NavcontrolComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NavcontrolComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
