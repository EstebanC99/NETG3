import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth/auth.service';
import { JwtService } from 'src/app/services/jwt/jwt-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  form: any = {
    username: null,
    password: null,
  };
  isLoggedIn = false;
  submitted = false;
  isLoginFailed = false;
  errorMessage = '';
  roles: string[] = [];

  loginForm = new FormGroup({
    usuario: new FormControl(null, [Validators.required]),
    password: new FormControl(null, [Validators.required, Validators.minLength(4)]),
  });
  constructor(private authService: AuthService, private router: Router, private jwtService:JwtService) {}

  ngOnInit(): void {}

  onSubmit(): void {
    if (this.loginForm.valid){
      const usuario = this.loginForm.controls.usuario.value!;
      const password = this.loginForm.controls.password.value!;
      this.submitted=true;
      this.authService.login(usuario, password).subscribe((res) => {
        if (res) {
          const decode=this.jwtService.DecodeToken(res);
          localStorage.setItem("token", res)
          localStorage.setItem("role", Object(decode).role)
          localStorage.setItem('usuario', usuario);
          this.router.navigate(['/inicio'])
        }
      });
      
      this.router.navigate(['/inicio'])
    }
  }

  reloadPage(): void {
    window.location.reload();
  }

  get controls(){
    return this.loginForm.controls;
  }
}
