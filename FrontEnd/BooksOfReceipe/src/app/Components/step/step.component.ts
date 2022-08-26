import { Component, OnInit } from '@angular/core';
import { Step } from 'src/app/Entityes/Steep';

@Component({
  selector: 'app-step',
  templateUrl: './step.component.html',
  styleUrls: ['./step.component.css']
})
export class StepComponent implements OnInit {

  _step: Step = {
    count: 0,
    description: "",
  }
  constructor(step:Step) {
    this._step = step; 
   }

  ngOnInit(): void {
  }

}
