import { Component, Input, OnInit } from '@angular/core';
import { TagClass } from 'src/app/Classes/TagClass';

@Component({
  selector: 'app-search-tag',
  templateUrl: './search-tag.component.html',
  styleUrls: ['./search-tag.component.css']
})
export class SearchTagComponent implements OnInit {

  constructor() { }

  @Input() tag: TagClass = {text:''};

  ngOnInit(): void {
  }

}
