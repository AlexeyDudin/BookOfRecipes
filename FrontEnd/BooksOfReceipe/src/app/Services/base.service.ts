import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ServerResponse } from 'src/app/Entityes/ServerResponse'
import { AppSettings } from 'src/app/constants'

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  result: any;

  constructor(private http: HttpClient) { }

  sendPost(routing: string, obj: any):Observable<ServerResponse> {
    return this.http.post<any>(AppSettings.hostAddress + routing, obj, {responseType: "json"});
  }

  sendGet(routing: string):Observable<ServerResponse> {
    return this.http.get<any>(AppSettings.hostAddress + routing, {responseType: "json"});
  }

  sendPostWithAuthHeader(routing: string, obj: any, token: string | null) {
    if (token === null)
      return this.sendPost(routing, obj);
    const headers = { 'Authorization': 'Bearer ' + token , 'My-Custom-Header': 'foobar' };
    return this.http.post<any>(AppSettings.hostAddress + routing, obj, {headers});
  }
}
