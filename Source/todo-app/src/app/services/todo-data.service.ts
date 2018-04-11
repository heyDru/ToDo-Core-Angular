import { Observable } from 'rxjs/Observable';
import { Injectable } from '@angular/core';
import { Todo } from '../todo';
import { TodoApiService } from './todo-api.service';

@Injectable()
export class TodoDataService {

  lastId: number = 0;

  todos: Todo[] = [];

  constructor(private todoApi: TodoApiService) { }

  getAllTodo(): Observable<Todo[]> {
    return this.todoApi.getAllTodos();
  }

  getTodoById(id: number): Observable<Todo> {
    return this.todoApi.getTodoById(id);
  }

  addTodo(todo: Todo): Observable<Todo> {
    return this.todoApi.createTodo(todo);
  }

  deleteTodoById(id: number): Observable<Todo> {
    return this.todoApi.deleteTodo(id);
  }

  updateTodoById(todo: Todo): Observable<Todo> {
    return this.todoApi.updateTodo(todo);
  }

  toggleTodoComplete(todo: Todo) {
    todo.complete = !todo.complete;
    return this.todoApi.updateTodo(todo);
  }
}
