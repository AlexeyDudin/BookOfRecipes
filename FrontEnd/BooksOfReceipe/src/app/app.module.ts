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
    SmartInfoCardComponent
  ],
  imports: [
    BrowserModule,
    MatSliderModule,
    BrowserAnimationsModule,
    RouterModule.forRoot([
      { path: '', component: HeaderComponent },
      { path: '', component: FooterComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }