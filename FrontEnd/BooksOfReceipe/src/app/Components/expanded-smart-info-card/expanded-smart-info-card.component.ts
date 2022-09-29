import { Component, Input, OnInit } from '@angular/core';
import { RecipeDto } from 'src/app/Entityes/Recipe';

@Component({
  selector: 'app-expanded-smart-info-card',
  templateUrl: './expanded-smart-info-card.component.html',
  styleUrls: ['./expanded-smart-info-card.component.css']
})
export class ExpandedSmartInfoCardComponent implements OnInit {

  constructor() {
    
   }

  starImage!: string;

  @Input() recipe: any;

  initialize() {
    this.starImage = "./asset/";
  }

  ngOnInit(): void {
    this.initialize();
  }

}
