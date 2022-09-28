import { Component, Input, OnInit } from '@angular/core';
import { Recipe } from 'src/app/Entityes/Recipe';
import { Step } from 'src/app/Entityes/Step';
import { StepClass } from 'src/app/Entityes/StepClass';

@Component({
  selector: 'app-step',
  templateUrl: './step.component.html',
  styleUrls: ['./step.component.css']
})
export class StepComponent implements OnInit {

  @Input() step!: Step;
  @Input() recipe!: Recipe;

  constructor() { 
   }

  ngOnInit(): void {
  }
  
  removeStep(): void {
    let newSteps: StepClass[] = [];
    let newCountSteps = 0;
    for (let i = 0; i < this.recipe.step.length; i++)
    {
      if (this.recipe.step[i] !== this.step)
      {
        newCountSteps++;
        this.recipe.step[i].count = i;
        newSteps.push(this.recipe.step[i]);
      }
    }
    this.recipe.step = newSteps;
  }
}
