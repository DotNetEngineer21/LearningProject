import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import CustomStore from '@node_modules/devextreme/data/custom_store';
import { DatagridServiceProxy, EmployeeModel } from '@shared/service-proxies/service-proxies';
import { DxDataGridComponent } from "devextreme-angular";

@Component({
  selector: 'app-datagrid',
  templateUrl: './datagrid.component.html',
  styleUrls: ['./datagrid.component.css']
})
export class DatagridComponent extends AppComponentBase implements OnInit {
  @ViewChild(DxDataGridComponent, { static: false }) dataGrid: DxDataGridComponent
  events: Array<string> = [];
  dataSource: any;
  editRowKey: number;
  countryList: Country[];
  collapsed = false;
    contentReady = (e) => {
        if(!this.collapsed) {
            this.collapsed = true;
            e.component.expandRow(["EnviroCare"]);
        }
    };
    customizeTooltip = (pointsInfo) => {
        return { text: parseInt(pointsInfo.originalValue) + "%" };
    }

    constructor(
      injector: Injector,
      private _datagridService: DatagridServiceProxy) {
        super(injector);
        this.dataSource = new CustomStore({
          key: "Id",
          load: () => _datagridService.getEmployees().toPromise().then(response => {
            return {
                data: response.items
              };
        }),
          insert: (values) => _datagridService.saveEmployee(values).toPromise().then(response => {
            return {
                data: response
              };
        }),                    
          update: async (key, values) => this.Update(key,values),
          remove: (key) => 
          _datagridService.deleteEmployee(key).toPromise().then(response => {
            return {
                data: response
              };
          })
        })
        this.countryList=countries;
    }
  ngOnInit(): void {
    
  }
  Update(employeeId: number | 0 | undefined,model: EmployeeModel | null | undefined){
    const editRowIndex = this.dataGrid.instance.getRowIndexByKey(this.editRowKey);
    if(editRowIndex >= 0) {
      if(!model.FullName){
      model.FullName= this.dataGrid.instance.cellValue(editRowIndex, "FullName");
      }
      if(!model.Position){
        model.Position= this.dataGrid.instance.cellValue(editRowIndex, "Position");
      }
      if(!model.BirthDate){
        model.BirthDate= this.dataGrid.instance.cellValue(editRowIndex, "BirthDate");
      }
      if(!model.HireDate){
        model.HireDate= this.dataGrid.instance.cellValue(editRowIndex, "HireDate");
      }
      if(!model.Address){
        model.Address= this.dataGrid.instance.cellValue(editRowIndex, "Address");
      }
      if(!model.City){
        model.City= this.dataGrid.instance.cellValue(editRowIndex, "City");
      }      
      if(!model.Country){
        model.Country= this.dataGrid.instance.cellValue(editRowIndex, "Country");
      }
      if(!model.HomePhone){
        model.HomePhone= this.dataGrid.instance.cellValue(editRowIndex, "HomePhone");
      }
      if(!model.PostalCode){
        model.PostalCode= this.dataGrid.instance.cellValue(editRowIndex, "PostalCode");
      }
    }
    this._datagridService.updateEmployee(employeeId,model).toPromise().then(response => {
      return {
          data: response
        };
  })
  }
  onEditingStart(e) {
    this.editRowKey = e.key;
  }
}
export class Country {
  ID: number;
  Name: string;
}
let countries: Country[] = [{
  "ID": 1,
  "Name": "America"
}, {
  "ID": 2,
  "Name": "Australia"
}, {
  "ID": 3,
  "Name": "India"
}];