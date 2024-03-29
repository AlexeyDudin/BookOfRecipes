import { Component, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import { User } from 'src/app/Entityes/user';
import { UcLoginComponent } from '../dialog-forms/uclogin/uclogin.component';
import { AppSettings } from 'src/app/constants';
import { StorageService } from 'src/app/Services/storage.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginSrc!: string;
  user: User | null = null;

  constructor(public dialog: MatDialog, private storage: StorageService) { }

  initUser() {
    this.user = this.storage.getUserFromStorage();
  }

  initialize() {
    this.loginSrc = "./assets/images/login.svg";
    this.initUser(); 
    this.storage.addSaveStorageCallback(() => this.initUser());
  }

  ngOnInit(): void {
    this.initialize();
  }

  unLoginUser() {
    this.user = this.storage.RemoveUserFromMemory();
  }
  
  openLoginDialog() {
    this.dialog.open(UcLoginComponent);
  }
}