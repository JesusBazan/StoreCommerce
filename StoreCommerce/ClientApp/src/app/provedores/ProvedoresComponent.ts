import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'provedores-app',
  templateUrl: './provedores.component.html',
  styleUrls: ['./provedores.component.css']
})
export class ProvedoresComponent {
  public nombre: string;
  public proveedor: Proveedor[];
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    http.get<Proveedor[]>(baseUrl + "api/Povedor/ProvedorList").subscribe(result => {
      this.proveedor = result;
      this.nombre = this.proveedor[1].Proveedor1;
      console.log("this.proveedor");
      console.log(this.proveedor);
    }, error => console.error(error));
  }
}

interface Proveedor {
  Idproveedor: number,
  Proveedor1: string,
  Telefono: number,
  Direccion: string
}
