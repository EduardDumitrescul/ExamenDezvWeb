import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { EvenimentService } from '../evenimente/eveniment.service';
import { Eveniment } from '../evenimente/eveniment';

@Component({
  selector: 'app-edit-evenimente',
  templateUrl: './edit-evenimente.component.html',
  styleUrls: ['./edit-evenimente.component.css']
})
export class EditEvenimenteComponent {
  evenimentForm = this.formBuilder.group({
    denumire: [''],
  })

  eveniment?: Eveniment;

  constructor(private readonly formBuilder: FormBuilder, private readonly evenimentService: EvenimentService) {

  }

  create() {
    console.log(this.evenimentForm.value);
      this.evenimentService.add(this.evenimentForm.value).subscribe((data: any) => console.log(data));
      
    
  
  }
}
