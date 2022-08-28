import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginSrc = "./assets/images/login.svg";

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }
  
  openLoginDialog() {
    this.dialog.open(LoginComponent);
  }
}