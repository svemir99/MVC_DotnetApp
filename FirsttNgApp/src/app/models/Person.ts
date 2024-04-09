export class Person {
  id: number;
  firstName: string;
  lastName: string;
  dateOfBirth: Date;
  isDeleted: number;

  constructor() {
    this.id = 0;
    this.firstName = '';
    this.lastName = '';
    this.dateOfBirth = new Date();
    this.isDeleted = 0;
  }
}
