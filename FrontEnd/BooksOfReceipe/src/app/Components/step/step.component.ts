import { Component, Input, OnInit } from '@angular/core';
import { RecipeDto } from 'src/app/Entityes/Recipe';
import { StepClass } from 'src/app/Entityes/StepClass';

@Component({
  selector: 'app-step',
  templateUrl: './step.component.html',
  styleUrls: ['./step.component.css']
})
export class StepComponent implements OnInit {

  @Input() step!: StepClass;
  @Input() recipe!: RecipeDto;

  constructor() { 
   }

  ngOnInit(): void {
  }
  
  removeStep(): void {
    let newSteps: StepClass[] = [];
    let newCountSteps = 0;
    for (let i = 0; i < this.recipe.steps.length; i++)
    {
      if (this.recipe.steps[i] !== this.step)
      {
        newCountSteps++;
        this.recipe.steps[i].number = i;
        newSteps.push(this.recipe.steps[i]);
      }
    }
    this.recipe.steps = newSteps;
  }
}
