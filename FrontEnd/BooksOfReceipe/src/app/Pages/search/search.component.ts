import { Component, OnInit } from '@angular/core';
import { TagClass } from 'src/app/Classes/TagClass';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor() { }

  tags: TagClass[] = [];

  ngOnInit(): void {
    this.tags = [{text:'Мясо'}, {text:'Деликатесы'}, {text:'Пироги'}, {text: 'Рыба'}]
  }

}
