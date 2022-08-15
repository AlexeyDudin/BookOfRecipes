import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatSliderModule } from '@angular/material/slider';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';
import { RouterModule } from '@angular/router';
import { RecomendationComponent } from './Pages/recomendation/recomendation.component';
import { SmartInfoComponent } from './Pages/smart-info/smart-info.component';
import { SearchComponent } from './Pages/search/search.component';
import { TopReceipeComponent } from './Pages/top-receipe/top-receipe.component';
import { MainPageComponent } from './Pages/main-page/main-page.component';
import { SmartInfoCardComponent } from './Components/smart-info-card/smart-info-card.component';
import { SearchTagComponent } from './Components/search-tag/search-tag.component';
import { LoginComponent } from './Components/login/login.component';
import { MatDialog, MAT_DIALOG_DEFAULT_OPTIONS } from '@angular/material/dialog';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    RecomendationComponent,
    SmartInfoComponent,
    SearchComponent,
    TopReceipeComponent,
    MainPageComponent,
    SmartInfoCardComponent,
    SearchTagComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    MatSliderModule,
    MatDialog,
    BrowserAnimationsModule,
    RouterModule.forRoot([
      { path: '', component: MainPageComponent },
      //{ path: 'recipes', component: FooterComponent },
    ])
  ],
  providers: [{provide: MAT_DIALOG_DEFAULT_OPTIONS, useValue: {hasBackdrop: false}}],
  bootstrap: [AppComponent]
})
export class AppModule { }