import { AbstractControl } from '@angular/forms';

const validatorKey = 'lowercase';

export default function lowerCaseValidator(control: AbstractControl) {
  const value = control.value.trim();

  if (value && !/^[a-z0-9_\-]+$/.test(value)) {
    return {
      [validatorKey]: true,
    };
  }

  return null;
}
