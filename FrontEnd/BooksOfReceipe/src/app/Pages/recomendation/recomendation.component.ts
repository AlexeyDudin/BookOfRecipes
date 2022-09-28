import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { UcLoginComponent } from 'src/app/Components/dialog-forms/uclogin/uclogin.component';

@Component({
  selector: 'app-recomendation',
  templateUrl: './recomendation.component.html',
  styleUrls: ['./recomendation.component.css']
})
export class RecomendationComponent implements OnInit {

  recomendationImage = "./assets/images/RecomendationImage.png";

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  login():void {
    this.dialog.open(UcLoginComponent);
  }
}
