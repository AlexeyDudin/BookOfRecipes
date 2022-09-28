import { Component, Input, OnInit } from '@angular/core';
import { TagClass } from 'src/app/Entityes/TagClass';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor() { }

  tags: TagClass[] = [];

  @Input() isShowHeaderText: boolean = true;

  ngOnInit(): void {
    this.tags = [{text:'Мясо'}, {text:'Деликатесы'}, {text:'Пироги'}, {text: 'Рыба'}]
  }
}
