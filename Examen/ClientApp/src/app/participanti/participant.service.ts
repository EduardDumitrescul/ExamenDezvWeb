import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Participant } from './participant';

@Injectable({
  providedIn: 'root'
})
export class ParticipantService {
  private readonly route = 'api/participant';
  constructor(private http: HttpClient) { }

  add(item: any) {
    var url = "/api/participant/create";

    return this.http.post<any>(url, item);
  }
}
