import { ThisReceiver } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';
import { mixinInitialized } from '@angular/material/core';
import { ActivatedRoute } from '@angular/router';
import { RecipeDto } from 'src/app/Entityes/Recipe';
import { User } from 'src/app/Entityes/user';
import { ResipeService } from 'src/app/Services/resipe.service';

@Component({
  selector: 'app-view-recipe',
  templateUrl: './view-recipe.component.html',
  styleUrls: ['./view-recipe.component.css']
})
export class ViewRecipeComponent implements OnInit {

  constructor(private route: ActivatedRoute, private recipeService: ResipeService) { }

  initialize() {
    this.recipe = new RecipeDto();
    let currentIdStr = this.route.snapshot.paramMap.get('id')?.toString();
    if (currentIdStr !== null && currentIdStr !== undefined) {
      this.recipe.id = Number.parseInt(currentIdStr);
      this.recipeService.getRecipeById(this.recipe.id).subscribe(res => {
        if (res.code == 0)
          this.recipe = res.content;
      });
    }
  }

  ngOnInit(): void {
    this.initialize();
  }

  public recipe!: RecipeDto;
}
