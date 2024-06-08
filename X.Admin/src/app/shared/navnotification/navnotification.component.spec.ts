import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavnotificationComponent } from './navnotification.component';

describe('NavnotificationComponent', () => {
  let component: NavnotificationComponent;
  let fixture: ComponentFixture<NavnotificationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NavnotificationComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NavnotificationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
