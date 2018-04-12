import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Todo } from '../../todo';

@Component({
  selector: 'todo-list-item',
  templateUrl: './todo-list-item.component.html',
  styleUrls: ['./todo-list-item.component.css']
})
export class TodoListItemComponent {
  @Input()
  todo: Todo;

  @Input()
  editState: boolean;

  @Input()
  todoToEditId:number;

  @Output()
  remove: EventEmitter<Todo> = new EventEmitter();

  @Output()
  toggleComplete: EventEmitter<Todo> = new EventEmitter();

  @Output()
  edit: EventEmitter<Todo> = new EventEmitter();

  @Output()
  update: EventEmitter<Todo> = new EventEmitter();

  constructor() { }

  toggleTodoComplete(todo) {
    this.toggleComplete.emit(todo);
  }

  removeTodo(todo) {
    this.remove.emit(todo);
  }

  editTodo(todo){
    this.edit.emit(todo);
  }

  updateTodo(){
    this.update.emit(this.todo)
  }

}
