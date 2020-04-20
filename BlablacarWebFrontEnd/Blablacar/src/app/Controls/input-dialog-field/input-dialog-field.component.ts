import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-input-dialog-field',
  templateUrl: './input-dialog-field.component.html',
  styleUrls: ['./input-dialog-field.component.scss']
})
export class InputDialogFieldComponent implements OnInit {

  @Input()
  caption: string;

  @Input()
  type: string;

  constructor() { }

  ngOnInit(): void {
  }

}
