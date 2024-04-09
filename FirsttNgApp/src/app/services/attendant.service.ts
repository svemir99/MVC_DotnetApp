import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable, of} from 'rxjs';
import { Person } from '../models/Person';
@Injectable({
  providedIn: 'root'
})
export class AttendantService {
  API_URL = `https://localhost:7175/api/attendant`;
  people: Person[];
  person: Person;
  personFormModel: FormGroup;
  constructor(private http: HttpClient) {
    this.person = new Person();
    this.people = [];
    this.personFormModel = new FormGroup({
      firstName: new FormControl('', Validators.required),
      lastName: new FormControl('', Validators.required),
      dateOfBirth: new FormControl('', [Validators.required])
    });

    

  }
  getAttendants(): Observable<Person[]> {
    return this.http.get<Person[]>(this.API_URL);
  }
  populatePersonObject() {
    this.person.firstName =
      this.personFormModel.controls["firstName"].value;
    this.person.lastName =
      this.personFormModel.controls["lastName"].value;
    this.person.dateOfBirth =
      this.personFormModel.controls["dateOfBirth"].value;
  }
  addAttendant(): Observable<any> {
    if (this.personFormModel.valid) {
      this.populatePersonObject();
      return this.http.post<Person>(this.API_URL, this.person);
    }
    return of<any>();
  }
}
