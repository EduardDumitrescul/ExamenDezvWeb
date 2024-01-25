import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { EvenimentService } from '../evenimente/eveniment.service';
import { ParticipantService } from '../participanti/participant.service';

@Component({
  selector: 'app-edit-participanti',
  templateUrl: './edit-participanti.component.html',
  styleUrls: ['./edit-participanti.component.css']
})
export class EditParticipantiComponent {
  partForm = this.formBuilder.group({
    nume: [''],
  })


  constructor(private readonly formBuilder: FormBuilder, private readonly partService: ParticipantService) {

  }

  create() {
    console.log(this.partForm.value);
    this.partService.add(this.partForm.value).subscribe((data: any) => console.log(data));



  }
}
