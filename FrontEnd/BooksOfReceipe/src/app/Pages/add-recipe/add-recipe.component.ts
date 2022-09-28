import { Component, Input, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { FloatLabelType } from '@angular/material/form-field';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { UcLoginComponent } from 'src/app/Components/dialog-forms/uclogin/uclogin.component';
import { IngridientClass } from 'src/app/Entityes/IngridientClass';
import { Recipe } from 'src/app/Entityes/Recipe';
import { RecipePhoto } from 'src/app/Entityes/RecipePhoto';
import { StepClass } from 'src/app/Entityes/StepClass';
import { ResipeService } from 'src/app/Services/resipe.service';
import { StorageService } from 'src/app/Services/storage.service';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {

  hideRequiredControl = new FormControl(false);
  floatLabelControl = new FormControl('auto' as FloatLabelType);

  uploadImagePath = "./assets/images/Upload.svg";

  recipe: Recipe = new Recipe();

  constructor(private route: ActivatedRoute, private router: Router, private recipeService: ResipeService, public storage: StorageService, private dialog: MatDialog) { }

  ngOnInit(): void {
    this.initialize();
  }

  checkOnUserLogin(): void {
    if (this.storage.getUserFromStorage() === null)
    {
      let result = this.dialog.open(UcLoginComponent);
      result.afterClosed().subscribe(result => 
        {
          if (this.storage.getUserFromStorage() === null)
            this.router.navigate(['']);
        }
        );
    }
  }
  
  initialize(): void {
    let currentIdStr = this.route.snapshot.paramMap.get('id')?.toString();
    if (currentIdStr !== null && currentIdStr !== undefined) {
      this.recipe.id = Number.parseInt(currentIdStr);
      this.recipeService.getRecipeById(this.recipe.id).subscribe(res => {
        if (res.code == 0)
          this.recipe = JSON.parse(res.content);
      });
    }
    this.recipe.imagePath = new RecipePhoto();
    this.recipe.imagePath.url = "./assets/images/ReceipeOfDay.png";
  }

  getFloatLabelValue(): FloatLabelType {
    return this.floatLabelControl.value || 'auto';
  }

  addIngridient():void {
    this.recipe.ingridients.push(new IngridientClass());
  }

  removeIngridient():void {
    this.recipe.ingridients.pop();
  }

  addStep():void {
    this.recipe.step.push(new StepClass(this.recipe.step.length + 1));
  }

  saveReceipe(): void {
    this.recipeService.saveRecipe(this.recipe).subscribe(res => 
      {
        if (res.code === 0)
          this.router.navigate(['recipes']);
      });
    
  }
}