

export interface Employee {
  id: number;
  name: string;
  admissionDate: Date;
  salary: number;
  isWorking: boolean;
  demissionDate?: Date;
  observation?: string;
}