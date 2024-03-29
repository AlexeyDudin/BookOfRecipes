import { Component, Inject, OnInit, Output } from '@angular/core';
import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Observable } from 'rxjs';
import { AppSettings } from 'src/app/constants';
import { User } from 'src/app/Entityes/user';
import { AuthService } from 'src/app/Services/auth.service';
import { StorageService } from 'src/app/Services/storage.service';
import { LoginComponent } from '../../login/login.component';

@Component({
  selector: 'app-uclogin',
  templateUrl: './uclogin.component.html',
  styleUrls: ['./uclogin.component.css']
})
export class UcLoginComponent implements OnInit {

  constructor(private auth: AuthService, public dialog: MatDialog, private storage:StorageService) { }

  public user!: User;

  public passwdConfirm: string = "";

  title!: string;
  text!: string;
  isShowText!:boolean;
  isShowLoginPage!: boolean;
  isShowRegisterPage!: boolean;
  hide!:boolean;

  closeCross = "./assets/images/CloseCross.svg"

  isInvalid: boolean = false;

  initialize(): void {
    this.user = {
      Login:"",
      Description:"",
      Password:"",
      Username:""
    }
    this.passwdConfirm = "";
  
    this.title = "Войдите в профиль";
    this.text = "Добавлять рецепты могут только зарегистрированные пользователи.";
    this.isShowText = true;
    this.isShowLoginPage = false;
    this.isShowRegisterPage = false;
    this.hide = true;
  
    this.closeCross = "./assets/images/CloseCross.svg"
  }

  ngOnInit(): void {
    this.initialize();
  }

  loginClick() {
    this.title = "Войти";
    this.isShowText = false;
    this.isShowLoginPage = true;
  }

  registerClick() {
    this.title = "Регистрация";
    this.isShowText = false;
    this.isShowRegisterPage = true;
  }

  loginPostClick() {
    this.auth.authorize(this.user).subscribe(res => {this.storage.saveToStorage(res.content); this.dialog.closeAll()});
  }

  registerPostClick() {
    if (this.user.Password !== this.passwdConfirm)
    {
      this.isInvalid = true;
    }
    else
    {
      this.auth.createUser(this.user).subscribe(res => 
        {
          this.storage.saveToStorage(res.content);
          this.dialog.closeAll();
          this.isInvalid = false;
        });
    }
  }
}
