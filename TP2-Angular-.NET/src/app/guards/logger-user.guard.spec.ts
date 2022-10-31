import { TestBed } from '@angular/core/testing';

import { LoggerUserGuard } from './logger-user.guard';

describe('LoggerUserGuard', () => {
  let guard: LoggerUserGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(LoggerUserGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
