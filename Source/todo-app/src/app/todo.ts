export class Todo {
    id:number;
    title:string;
    complete:boolean=false;
    expirationTime:DateTimeFormat
    dateCreated:Date;
    dateUpdated:Date;

    constructor(values:Object={}) {
        Object.assign(this,values);
    }
}
