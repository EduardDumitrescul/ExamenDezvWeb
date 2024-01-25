import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Participant } from './participant';

@Component({
  selector: 'app-participanti',
  templateUrl: './participanti.component.html',
  styleUrls: ['./participanti.component.css']
})
export class ParticipantiComponent {
  public participanti: Participant[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Participant[]>(baseUrl + 'api/participant/all').subscribe(result => {
      this.participanti = result;
    }, error => console.error(error));
  }
}
