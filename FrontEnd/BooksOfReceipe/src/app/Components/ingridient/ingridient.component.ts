import { Component, Input, OnInit } from '@angular/core';
import { IngridientClass } from 'src/app/Entityes/IngridientClass';

@Component({
  selector: 'app-ingridient',
  templateUrl: './ingridient.component.html',
  styleUrls: ['./ingridient.component.css']
})
export class IngridientComponent implements OnInit {

  @Input() ingridient!: IngridientClass;

  constructor() { }

  ngOnInit(): void {
  }

}
