import { Component, OnInit, Input } from '@angular/core';

interface IValue {
  Id: number;
  Name: string;
}

@Component({
  selector: 'app-list-of-values',
  templateUrl: './list-of-values.component.html',
  styleUrls: ['./list-of-values.component.scss']
})

export class ListOfValuesComponent implements OnInit {

  @Input()
  label: string;

  @Input()
  values: IValue[];

  constructor() { }

  ngOnInit(): void {
  }

}
