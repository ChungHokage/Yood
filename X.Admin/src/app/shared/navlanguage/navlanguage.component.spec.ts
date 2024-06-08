import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavlanguageComponent } from './navlanguage.component';

describe('NavlanguageComponent', () => {
  let component: NavlanguageComponent;
  let fixture: ComponentFixture<NavlanguageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NavlanguageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NavlanguageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
