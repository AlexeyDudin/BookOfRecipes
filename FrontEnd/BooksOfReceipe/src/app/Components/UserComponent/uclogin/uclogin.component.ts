import { Component, Inject, OnInit, Output } from '@angular/core';
import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Observable } from 'rxjs';
import { User } from 'src/app/Entityes/user';
import { AuthService } from 'src/app/Services/auth.service';
import { LoginComponent } from '../../login/login.component';

@Component({
  selector: 'app-uclogin',
  templateUrl: './uclogin.component.html',
  styleUrls: ['./uclogin.component.css']
})
export class UcLoginComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA) public data: {loginComponent: LoginComponent}, private auth: AuthService) { }

  public user!: User;

  public passwdConfirm: string = "";

  title!: string;
  text!: string;
  isShowText!:boolean;
  isShowLoginPage!: boolean;
  isShowRegisterPage!: boolean;
  hide!:boolean;

  closeCross = "./assets/images/CloseCross.svg"

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

  loginPostClick():Observable<any> {
    const request = this.auth.authorize(this.user);
    request.subscribe(res => {this.data.loginComponent.onChangeUser(res.content)});
    return request;
  }

  registerPostClick() {
    this.auth.createUser(this.user).subscribe(res => {this.data.loginComponent.onChangeUser(res.content)});
  }
}
