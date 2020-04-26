import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { ControlValueAccessor } from '@angular/forms';

interface IValue {
  Id: number;
  Name: string;
}

const noop = () => {
};

@Component({
  selector: 'app-list-of-values',
  templateUrl: './list-of-values.component.html',
  styleUrls: ['./list-of-values.component.scss']
})

export class ListOfValuesComponent implements ControlValueAccessor {

  //The internal data model
  private innerValue: any = '';

  //Placeholders for the callbacks which are later providesd
  //by the Control Value Accessor
  private onTouchedCallback: () => void = noop;
  private onChangeCallback: (_: any) => void = noop;

  @Input()
  label: string;

  @Input()
  objects: IValue[];

  constructor() { }

  ngOnInit(): void {
  }

  //get accessor
  get value(): any {
    return this.innerValue;
  };

  //set accessor including call the onchange callback
  set value(v: any) {
    if (v !== this.innerValue) {
      this.innerValue = v;
      this.onChangeCallback(v);
    }
  }

  //Set touched on blur
  onBlur() {
    this.onTouchedCallback();
  }

  //From ControlValueAccessor interface
  writeValue(value: any) {
    if (value !== this.innerValue) {
      this.innerValue = value;
    }
  }

  //From ControlValueAccessor interface
  registerOnChange(fn: any) {
    this.onChangeCallback = fn;
  }

  //From ControlValueAccessor interface
  registerOnTouched(fn: any) {
    this.onTouchedCallback = fn;
  }
}
