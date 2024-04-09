import { Component, OnInit } from '@angular/core';
import { Person } from '../models/Person';
import { AttendantService } from '../services/attendant.service';
@Component({
  selector: 'app-add-attendant',
  templateUrl: './add-attendant.component.html',
  styleUrls: ['./add-attendant.component.css']
})
export class AddAttendantComponent implements OnInit {
  constructor(public service: AttendantService) { }
  ngOnInit(): void {
  }
  public onAttendantSave() {
    this.service.addAttendant().subscribe(data => {
      this.service.person.id = data.id;
      this.service.people.push(this.service.person);
      this.service.person = new Person();
      this.service.personFormModel.reset();
    });
  }
}
