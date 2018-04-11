export class Todo {
    id:number;
    title:string;
    complete:boolean=false;
    dateCreated:Date;
    dateUpdated:Date;

    constructor(values:Object={}) {
        Object.assign(this,values);
    }
}
