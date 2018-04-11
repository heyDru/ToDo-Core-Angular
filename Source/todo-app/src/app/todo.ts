export class Todo {
    id:number;
    title:string;
    description:string;
    complete:boolean=false;
    expirationTime:Date

    constructor(values:Object={}) {
        Object.assign(this,values);
    }
}
