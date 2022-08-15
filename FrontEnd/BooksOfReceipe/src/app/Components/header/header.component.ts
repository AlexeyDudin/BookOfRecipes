import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import { LoginComponent } from '../login/login.component';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  logoSrc = "./assets/images/Recipes.svg";
  loginSrc = "./assets/images/login.svg";

  constructor(public dialog: MatDialog) { }
  
  ngOnInit(): void {
  }
  
  openDialog() {
    this.dialog.open(LoginComponent);
  }
}