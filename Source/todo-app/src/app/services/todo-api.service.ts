import { Todo } from './../todo';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

const API_URL = environment.apiUrl;

@Injectable()
export class TodoApiService {

  constructor(private http: Http) { }

  getAllTodos():Observable<Todo[]> {
    return this.http
    .get(API_URL+'/todos')
    .map((response)=>{
      let todos = response.json();
      let result = todos.map((todo)=>new Todo(todo));
      return result;
    })
    .catch(this.handleError);
  }

  createTodo(todo:Todo):Observable<Todo>{
    return this.http
    .post(API_URL+'/todos',todo)
    .map(response=>{
      return new Todo(response.json())
    })
    .catch(this.handleError);
  }
  
  deleteTodo(id: number): Observable<null> {
    return this.http
      .delete(API_URL + '/todos/' + id)
      .map(response => null)
      .catch(this.handleError);
  }

  updateTodo(todo:Todo):Observable<Todo>{
    return this.http
    .put(API_URL+'/todos/'+todo.id,todo)
    .map(response=>{
      return new Todo(response.json());
    })
    .catch(this.handleError);
  }

  getTodoById(id:number):Observable<Todo>{
    return this.http
    .get(API_URL+'/todos/'+id)
    .map(response=>{
      return new Todo(response.json())
    })
    .catch(this.handleError);
  }

  private handleError (error: Response | any) {
    console.error('ApiService::handleError', error);
    return Observable.throw(error);
  }
}
