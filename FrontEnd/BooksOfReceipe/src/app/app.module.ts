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
import { UcLoginComponent } from './Components/dialog-forms/uclogin/uclogin.component';
import { LoginComponent } from './Components/login/login.component';
import { MatDialogModule, MAT_DIALOG_DEFAULT_OPTIONS } from '@angular/material/dialog';
import { RegistrationComponent } from './Components/dialog-forms/registration/registration.component';
import { ErrorStateMatcher, ShowOnDirtyErrorStateMatcher } from '@angular/material/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {MatNativeDateModule} from '@angular/material/core';
import {MatInputModule} from '@angular/material/input';
import {MAT_FORM_FIELD_DEFAULT_OPTIONS} from '@angular/material/form-field';
import { RecipesComponent } from './Pages/recipes/recipes.component';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { ExpandedSmartInfoCardComponent } from './Components/expanded-smart-info-card/expanded-smart-info-card.component';
import { StepComponent } from './Components/step/step.component';
import { ViewRecipeComponent } from './Pages/view-recipe/view-recipe.component';
import { HttpClientModule } from '@angular/common/http';
import { AddRecipeComponent } from './Pages/add-recipe/add-recipe.component';
import { IngridientComponent } from './Components/ingridient/ingridient.component';

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
    UcLoginComponent,
    LoginComponent,
    RegistrationComponent,
    RecipesComponent,
    ExpandedSmartInfoCardComponent,
    StepComponent,
    ViewRecipeComponent,
    AddRecipeComponent,
    IngridientComponent
  ],
  imports: [
    BrowserModule,
    MatSliderModule,
    MatDialogModule,
    BrowserAnimationsModule,
    MatNativeDateModule,
    FormsModule,
    MatInputModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: MainPageComponent },
      { path: 'recipes', component: RecipesComponent },
      { path: 'recipe/:id', component: ViewRecipeComponent}, // TODO
      { path: 'edit-recipe/:id', component: AddRecipeComponent}, //TODO
      { path: 'add-recipe', component: AddRecipeComponent},
    ])
  ],
  providers: [
    {provide: MAT_DIALOG_DEFAULT_OPTIONS, useValue: {hasBackdrop: false}}, 
    {provide: ErrorStateMatcher, useClass: ShowOnDirtyErrorStateMatcher},
    {provide: MAT_FORM_FIELD_DEFAULT_OPTIONS, useValue: {appearance: 'fill'}}],
  bootstrap: [AppComponent]
})
export class AppModule { }