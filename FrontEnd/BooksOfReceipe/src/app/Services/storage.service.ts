import { Injectable } from '@angular/core';
import { AppSettings } from '../constants';
import { User } from '../Entityes/user';
import jwt_decode from 'jwt-decode';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class StorageService {

  constructor(private auth: AuthService) { }

  saveToStorage(storageInfo: string) {
    localStorage.setItem(AppSettings.localStorageKey, storageInfo);
    if (this.onSaveStorage !== null) {
      this.onSaveStorage();
    }
  }

  addSaveStorageCallback(onSaveStorage: () => void) {
    this.onSaveStorage = onSaveStorage;
  }

  private onSaveStorage: () => void = () => {};

  private getDecodedAccessToken(token: string): any {
    try {
      return jwt_decode(token);
    } catch(Error) {
      return null;
    }
  }

  private isTokenTimeExpired(expireDate: any):boolean {
    var currentTimeInMilliseconds=(Date.now() / 1000);
    return currentTimeInMilliseconds > expireDate
  } 

  RemoveUserFromMemory() {
    localStorage.removeItem(AppSettings.localStorageKey);
    return null;
  }

  getToken() {
    return localStorage.getItem(AppSettings.localStorageKey);
  }

  getUserFromStorage() {
    let user: User;
    let memoryInfo = localStorage.getItem(AppSettings.localStorageKey);
    if (!(memoryInfo === null || memoryInfo === "undefined"))
    {
      const tokenInfo = this.getDecodedAccessToken(memoryInfo);
      const expireDate = tokenInfo.exp;

      if (this.isTokenTimeExpired(expireDate))
      {
        this.RemoveUserFromMemory();
      }
      else
      {
        user = new User(); 
        user.Login = tokenInfo.login;
        user.Username = tokenInfo.username;
        return user;
      }
    }
    return null;
  }
}
