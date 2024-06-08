import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidebarComponent } from './sidebar/sidebar.component';
import { HeadbarComponent } from './headbar/headbar.component';
import { PreloadComponent } from './preload/preload.component';
import { NavheaderComponent } from './navheader/navheader.component';
import { NavcontrolComponent } from './navcontrol/navcontrol.component';
import { SearchbarComponent } from './searchbar/searchbar.component';
import { NavprofileComponent } from './navprofile/navprofile.component';
import { NavlanguageComponent } from './navlanguage/navlanguage.component';
import { NavnotificationComponent } from './navnotification/navnotification.component';



@NgModule({
  declarations: [
    SidebarComponent,
    HeadbarComponent,
    PreloadComponent,
    NavheaderComponent,
    NavcontrolComponent,
    SearchbarComponent,
    NavprofileComponent,
    NavlanguageComponent,
    NavnotificationComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    SidebarComponent,
    HeadbarComponent,
    PreloadComponent
  ]
})
export class SharedModule { }
