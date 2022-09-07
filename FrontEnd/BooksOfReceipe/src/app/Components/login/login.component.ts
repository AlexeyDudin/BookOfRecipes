import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import { User } from 'src/app/Entityes/user';
import { UcLoginComponent } from '../UserComponent/uclogin/uclogin.component';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginSrc!: string;
  user: any;

  constructor(public dialog: MatDialog) { }

  initialize() {
    this.loginSrc = "./assets/images/login.svg";
    this.user = null;
  }

  ngOnInit(): void {
    this.initialize();
  }
  
  openLoginDialog() {
    this.dialog.open(UcLoginComponent);
  }
}